
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel;
using System.Text;
using System.Reflection;

using OfficeOpenXml;

using Core.Insfrastructure.Caching;
using Core.Models.URM;
using System.Data;



//using System.Web.UI.WebControls;
namespace Core.Insfrastructure.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
#nullable disable
    public class BaseApiController : ControllerBase
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        protected readonly IConfiguration configuration;

        protected BaseApiController(IConfiguration Configuration, IHttpContextAccessor _httpContextAccessor)
        {
            this.configuration = Configuration;
            httpContextAccessor = _httpContextAccessor;
        }
        private void PrepareHttpClientRequest(HttpClient client, string baseAddress, bool addSession = true)
        {
            try
            {
                //if (addSession == true)
                //    client.DefaultRequestHeaders.Add("UserSessionObject", Session.SeriaizeUserSessionData());

                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("UserIPAddress", httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString());
                foreach (var header in httpContextAccessor.HttpContext.Request.Headers)
                {
                    string headerName = header.Key;
                    string headerContent = string.Join(",", header.Value.ToArray());
                    client.DefaultRequestHeaders.TryAddWithoutValidation(headerName, headerContent);
                }

                //client.DefaultRequestHeaders.Add("UserIPAddress", httpContextAccessor.HttpContext.Request.Headers["Host"].ToString());
                //client.DefaultRequestHeaders.Add("UserBrowser", context.Request.Browser.Browser.ToString() + " " + HttpContext.Current.Request.Browser.Version);
                //client.DefaultRequestHeaders.Add("UserDevice", (context.Current.Request.Browser.IsMobileDevice ? ("Mobile-" + HttpContext.Current.Request.Browser.MobileDeviceModel + " (" + HttpContext.Current.Request.Browser.MobileDeviceManufacturer + ")") : "Desktop"));
                //client.DefaultRequestHeaders.Add("UserUserAgent", httpContextAccessor.HttpContext.Request.Headers["User-Agent"].ToString());
                //client.DefaultRequestHeaders.Add("UserLoginUrl", httpContextAccessor.HttpContext.Request.Headers["Referer"].ToString());
                //client.DefaultRequestHeaders.Add("Language", httpContextAccessor.HttpContext.Request.Headers["Language"].ToString());
            }
            catch (Exception)
            {
                //throw ex;
            }
        }

        private bool IsAscii(string value)
        {
            return value.All(c => c <= 127); // ASCII range
        }

        protected async Task<dynamic> CallPostWebAPI<T>(string apiNameWithParameter, T postModel, string baseAddress)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    PrepareHttpClientRequest(client, baseAddress);
                    baseAddress = client.BaseAddress.ToString();
                    var result = await client.PostAsJsonAsync<T>(apiNameWithParameter, postModel).ConfigureAwait(false);
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var responseString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                    ResponseModel responseModel = JsonSerializer.Deserialize<ResponseModel>(responseString, options);
                    return responseModel;
                }
            }
            catch (Exception)
            {
                //ServiceUserSession.writeErrorLog("Base Address=" + baseAddress + "apiNameWithParameter=" + apiNameWithParameter, "Error in CallPostWebAPI", ex.ToString());
                //Logs.Log.WriteErrorLog("Base Address=" + baseAddress + "apiNameWithParameter=" + apiNameWithParameter, Logs.ErrorType.HTTP, ex);
                throw;
            }
        }
        protected async Task<dynamic> CallPostWebAPIWithoutSession<T>(string apiNameWithParameter, T postModel, string baseAddress)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    PrepareHttpClientRequest(client, baseAddress, false);
                    baseAddress = client.BaseAddress.ToString();
                    var result = await client.PostAsJsonAsync<T>(apiNameWithParameter, postModel).ConfigureAwait(false);
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var responseString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                    ResponseModel responseModel = JsonSerializer.Deserialize<ResponseModel>(responseString, options);
                    return responseModel;
                }
            }
            catch (Exception)
            {
                //ServiceUserSession.writeErrorLog("Base Address=" + baseAddress + "apiNameWithParameter=" + apiNameWithParameter, "Error in CallPostWebAPI", ex.ToString());
                //Logs.Log.WriteErrorLog("Base Address=" + baseAddress + "apiNameWithParameter=" + apiNameWithParameter, Logs.ErrorType.HTTP, ex);
                throw;
            }
        }
        public dynamic CallPostWebAPIWithoutSessionSync<T>(string apiNameWithParameter, T postModel, string baseAddress)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    PrepareHttpClientRequest(client, baseAddress, false);
                    baseAddress = client.BaseAddress.ToString();
                    var responseTask = client.PostAsJsonAsync<T>(apiNameWithParameter, postModel);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    var responseString = result.Content.ReadAsStringAsync();
                    responseString.Wait();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    ResponseModel responseModel = JsonSerializer.Deserialize<ResponseModel>(responseString.Result, options);
                    return responseModel;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //[NonAction]
        //protected async Task<ResponseModel> GetApiConfigModel(Int32 orgId, string apiKey, string endpointClassName = "", string endpointFunctionName = "")
        //{
        //    string baseURL = configuration["ServiceURL:CFG"];
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri(baseURL);
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            var result = await client.GetAsync("Configuration/GetAPIConfigModelByApiKey?OrgId=" + orgId.ToString() + "&apiKey=" + apiKey + "&endpointClassName=" + endpointClassName + "&endpointFunctionName=" + endpointFunctionName).ConfigureAwait(false);
        //            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        //            var responseString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
        //            ResponseModel responseModel = JsonSerializer.Deserialize<ResponseModel>(responseString, options);
        //            return responseModel;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        [NonAction]
        protected ResponseModel GetApiConfigModel(CacheManager _cacheManager, Int32 orgId, string apiKey, string endpointClassName = "", string endpointFunctionName = "")
        {
            string baseURL = configuration["ServiceURL:CFG"];
            ResponseModel responseModel = new ResponseModel();
            try
            {
                List<APIConfigModel> api;
                api = _cacheManager.GetOrAdd("Gateway.APILIST", () => GetApiConfigList(orgId, baseURL, apiKey, endpointClassName, endpointFunctionName), TimeSpan.FromMinutes(60));
                //api=GetApiConfigList(orgId, baseURL, apiKey, endpointClassName, endpointFunctionName);

                responseModel.CustomObject = JsonSerializer.Serialize(api.Where(s => s.ApiKey.ToLower() == apiKey.ToLower() && s.SourceEndpointClassName.ToLower() == endpointClassName.ToLower() && s.SourceEndpointFunctionName.ToLower() == endpointFunctionName.ToLower()).FirstOrDefault());
                return responseModel;
            }
            catch (Exception)
            {
                //ServiceUserSession.writeErrorLog("baseURL=" + baseURL + "apiNameWithParameter=" + "URM_APIConfigService/GetAPIConfigModelByApiKey?OrgId=" + orgId.ToString() + "&apiKey=" + apiKey, "Error in GetApiConfigModel", ex.ToString());
                //Logs.Log.WriteErrorLog("Base Address=" + baseAddress + "apiNameWithParameter=" + apiNameWithParameter, Logs.ErrorType.HTTP, ex);
                throw;
            }
        }
        [NonAction]
        private static List<APIConfigModel> GetApiConfigList(int orgId, string baseURL, string apiKey, string endpointClassName, string endpointFunctionName)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var result = client.GetAsync("Configuration/GetAPIConfigModelByApiKey?OrgId=" + orgId.ToString() + "&apiKey=" + apiKey + "&endpointClassName=" + endpointClassName + "&endpointFunctionName=" + endpointFunctionName);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var responseString = result.Result.Content.ReadAsStringAsync().Result;
                var responseModel = JsonSerializer.Deserialize<ResponseModel>(responseString, options);
                List<APIConfigModel> apivalues = JsonSerializer.Deserialize<List<APIConfigModel>>(responseModel.CustomObject, options);
                return apivalues;
            }
        }


        public static string GetFileFromData(List<ExportHeader> exportheaderlist, List<ExportHeaderData> exportheaderdata, string title, out string base64,bool pageOrientation=false,string FilterHeading=null, int ExportType=0,string header="")
        {
            try
            {
                //ExportType 1(Excel),2(PDF)
                StringBuilder sb = new StringBuilder();
                int headerCount = exportheaderlist.Count;
               
                sb.Append("<table cellpadding='3'  width=100% border=1 style='border-collapse:collapse'>");                

                sb.Append("<thead>");
                sb.Append("<tr >");
                sb.Append("<th colspan="+ headerCount + " style='text-align:center;font-size: 14px;font-weight: bold;' >" + header + "</th>");
                sb.Append("</tr>");
                if (!string.IsNullOrEmpty(FilterHeading))
                {
                    sb.Append("<tr >");
                    sb.Append("<th colspan="+ headerCount + " style='text-align:left;font-size: 14px;font-weight: bold;' >" + FilterHeading + "</th>");
                    sb.Append("</tr>");
                }

                sb.Append("<tr>");

                foreach (var itemHeader in exportheaderlist.ToList())
                {
                    sb.Append("<th style='display:table-cell; padding-bottom:20px; margin-bottom:20px; '>"+ itemHeader.ColHeader + "</th>");
                }
                sb.Append("</tr>");
                sb.Append("</thead>");
                sb.Append("<tbody>");
                
                foreach (var itemdata in exportheaderdata.ToList())
                {
                    sb.Append("<tr>");
                    
                    if (headerCount == 2)
                    {
                        sb.Append("<td >" + itemdata.Col1 + "</td>");
                        sb.Append("<td >" + itemdata.Col2 + "</td>");
                    }
                    else if (headerCount == 3)
                    {
                        sb.Append("<td >" + itemdata.Col1 + "</td>");
                        sb.Append("<td >" + itemdata.Col2 + "</td>");
                        sb.Append("<td >" + itemdata.Col3 + "</td>");
                    }
                    else if (headerCount == 4)
                    {
                        sb.Append("<td >" + itemdata.Col1 + "</td>");
                        sb.Append("<td >" + itemdata.Col2 + "</td>");
                        sb.Append("<td >" + itemdata.Col3 + "</td>");
                        sb.Append("<td >" + itemdata.Col4 + "</td>");
                    }
                    else if (headerCount == 5)
                    {
                        sb.Append("<td >" + itemdata.Col1 + "</td>");
                        sb.Append("<td >" + itemdata.Col2 + "</td>");
                        sb.Append("<td >" + itemdata.Col3 + "</td>");
                        sb.Append("<td >" + itemdata.Col4 + "</td>");
                        sb.Append("<td >" + itemdata.Col5 + "</td>");
                    }
                    else if (headerCount == 6)
                    {
                        sb.Append("<td >" + itemdata.Col1 + "</td>");
                        sb.Append("<td >" + itemdata.Col2 + "</td>");
                        sb.Append("<td >" + itemdata.Col3 + "</td>");
                        sb.Append("<td >" + itemdata.Col4 + "</td>");
                        sb.Append("<td >" + itemdata.Col5 + "</td>");
                        sb.Append("<td >" + itemdata.Col6 + "</td>");
                    }
                    else if (headerCount == 7)
                    {
                        sb.Append("<td >" + itemdata.Col1 + "</td>");
                        sb.Append("<td >" + itemdata.Col2 + "</td>");
                        sb.Append("<td >" + itemdata.Col3 + "</td>");
                        sb.Append("<td >" + itemdata.Col4 + "</td>");
                        sb.Append("<td >" + itemdata.Col5 + "</td>");
                        sb.Append("<td >" + itemdata.Col6 + "</td>");
                        sb.Append("<td >" + itemdata.Col7 + "</td>");
                    }
                    else if (headerCount == 8)
                    {
                        sb.Append("<td >" + itemdata.Col1 + "</td>");
                        sb.Append("<td >" + itemdata.Col2 + "</td>");
                        sb.Append("<td >" + itemdata.Col3 + "</td>");
                        sb.Append("<td >" + itemdata.Col4 + "</td>");
                        sb.Append("<td >" + itemdata.Col5 + "</td>");
                        sb.Append("<td >" + itemdata.Col6 + "</td>");
                        sb.Append("<td >" + itemdata.Col7 + "</td>");
                        sb.Append("<td >" + itemdata.Col8 + "</td>");
                    }
                    else if (headerCount == 9)
                    {
                        sb.Append("<td >" + itemdata.Col1 +"</td>");
                        sb.Append("<td >" + itemdata.Col2 +"</td>");
                        sb.Append("<td >" + itemdata.Col3 +"</td>");
                        sb.Append("<td >" + itemdata.Col4 +"</td>");
                        sb.Append("<td >" + itemdata.Col5 +"</td>");
                        sb.Append("<td >" + itemdata.Col6 +"</td>");
                        sb.Append("<td >" + itemdata.Col7 +"</td>");
                        sb.Append("<td >" + itemdata.Col8 +"</td>");
                        sb.Append("<td >" + itemdata.Col9 + "</td>");
                    }
                    else if (headerCount == 10)
                    {
                        sb.Append("<td >" + itemdata.Col1 + "</td>");
                        sb.Append("<td >" + itemdata.Col2 + "</td>");
                        sb.Append("<td >" + itemdata.Col3 + "</td>");
                        sb.Append("<td >" + itemdata.Col4 + "</td>");
                        sb.Append("<td >" + itemdata.Col5 + "</td>");
                        sb.Append("<td >" + itemdata.Col6 + "</td>");
                        sb.Append("<td >" + itemdata.Col7 + "</td>");
                        sb.Append("<td >" + itemdata.Col8 + "</td>");
                        sb.Append("<td >" + itemdata.Col9 + "</td>");
                        sb.Append("<td >" + itemdata.Col10 + "</td>");

                    }
                    else if (headerCount == 11)
                    {
                        sb.Append("<td >" + itemdata.Col1 +"</td>");
                        sb.Append("<td >" + itemdata.Col2 +"</td>");
                        sb.Append("<td >" + itemdata.Col3 +"</td>");
                        sb.Append("<td >" + itemdata.Col4 +"</td>");
                        sb.Append("<td >" + itemdata.Col5 +"</td>");
                        sb.Append("<td >" + itemdata.Col6 +"</td>");
                        sb.Append("<td >" + itemdata.Col7 +"</td>");
                        sb.Append("<td >" + itemdata.Col8 +"</td>");
                        sb.Append("<td >" + itemdata.Col9 + "</td>");
                        sb.Append("<td >" + itemdata.Col10 + "</td>");
                        sb.Append("<td >" + itemdata.Col11 + "</td>");
                    }
                    else if (headerCount == 12)
                    {
                        sb.Append("<td >" + itemdata.Col1 + "</td>");
                        sb.Append("<td >" + itemdata.Col2 + "</td>");
                        sb.Append("<td >" + itemdata.Col3 + "</td>");
                        sb.Append("<td >" + itemdata.Col4 + "</td>");
                        sb.Append("<td >" + itemdata.Col5 + "</td>");
                        sb.Append("<td >" + itemdata.Col6 + "</td>");
                        sb.Append("<td >" + itemdata.Col7 + "</td>");
                        sb.Append("<td >" + itemdata.Col8 + "</td>");
                        sb.Append("<td >" + itemdata.Col9 + "</td>");
                        sb.Append("<td >" + itemdata.Col10 + "</td>");
                        sb.Append("<td >" + itemdata.Col11 + "</td>");
                        sb.Append("<td >" + itemdata.Col12 + "</td>");
                    }
                    
                    sb.Append("</tr>");
                }
                              
                

                sb.Append("</tbody>");
                sb.Append("</table>");
                if (ExportType == 1)
                {
                    base64 = GetFileFromHtmlDataExcel(sb.ToString(), header, title, FilterHeading, true);
                }
                else
                {
                    base64 = GetPdfBase64StringOrBytes(header, "SubHeader", title, FilterHeading, sb.ToString(), false, pageOrientation);

                }

               
                //var dataStream = new MemoryStream(bt);
                //response.Content = new StreamContent(dataStream);
                //response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                //response.Content.Headers.ContentDisposition.FileName = fileNameWithExtension;
                ////Set the File Content Type.
                //response.Content.Headers.ContentType = new MediaTypeHeaderValue(MimeMapping.GetMimeMapping(fileNameWithExtension));

                return base64;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
		public static string GetFileFromDataNew<T>(IEnumerable<T> data, string title, out string base64, bool pageOrientation = false, string FilterHeading = null, int ExportType = 0, string header = "", Dictionary<string, string> dicColumnNames = null)
		{
			try
			{
				//ExportType 1(Excel),2(PDF)

				StringBuilder sb = new StringBuilder();
				string heading = "Rajasthan Sampark 2.0";
				if (ExportType == 1)
				{
                    //Excel Sheet
                   
                    base64 = GetFileFromHtmlDataExcelNew(title, heading, dicColumnNames.Count, FilterHeading, data);
				}
				else
				{
                    // PDF
                    //base64 = GetPdfBase64StringOrBytesNew(title, heading, dicColumnNames.Count, FilterHeading,data);
                    base64 = ExportDataTableToPdfitext7(title, heading, dicColumnNames.Count, FilterHeading,data.ToList(), dicColumnNames);
                    //base64 = "";

                }

                return base64;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static string GetFileFromDataNew1<T>(IEnumerable<T> data, string title, out string base64, bool pageOrientation = false, string FilterHeading = null, int ExportType = 0, string header = "", Dictionary<string, string> dicColumnNames = null)
        {
            try
            {
                //ExportType 1(Excel),2(PDF)

                var props = typeof(T).GetProperties();

                StringBuilder sb = new StringBuilder();
                int headerCount = dicColumnNames.Count;

                sb.Append("<table cellpadding='3'  width=100% border=1 style='border-collapse:collapse'>");

                sb.Append("<thead>");
                sb.Append("<tr >");
                sb.Append("<th colspan="+ headerCount + " style='text-align:center;font-size: 14px;font-weight: bold;' >" + header + "</th>");
                sb.Append("</tr>");
                if (!string.IsNullOrEmpty(FilterHeading))
                {
                    sb.Append("<tr >");
                    sb.Append("<th colspan="+ headerCount + " style='text-align:left;font-size: 14px;font-weight: bold;' >" + FilterHeading + "</th>");
                    sb.Append("</tr>");
                }

                sb.Append("<tr>");
                foreach (var prop in props)
                {
                    var name = dicColumnNames != null ? dicColumnNames[prop.Name] : prop.Name;
                        sb.Append("<th style='display:table-cell; padding-bottom:20px; margin-bottom:20px; '>" + name + "</th>");
                }

                //foreach (var itemHeader in exportheaderlist.ToList())
                //{
                //    sb.Append("<th style='display:table-cell; padding-bottom:20px; margin-bottom:20px; '>" + itemHeader.ColHeader + "</th>");
                //}
                sb.Append("</tr>");
                sb.Append("</thead>");
                sb.Append("<tbody>");

                foreach (var row in data)
                {
                    sb.Append("<tr style='page-break-inside: always;'>");

                    foreach (PropertyInfo prop in props)
                    {
                        sb.Append("<td>" + prop.GetValue(row) + "</td>");
                    }  sb.Append("</tr>");
                }



                sb.Append("</tbody>");
                sb.Append("</table>");
                if (ExportType == 1)
                {
                    base64 = GetFileFromHtmlDataExcel(sb.ToString(), header, title, FilterHeading, true);
                }
                else
                {
                    base64 = GetPdfBase64StringOrBytes(header, "SubHeader", title, FilterHeading, sb.ToString(), false, pageOrientation);

                }

                return base64;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static dynamic GetPdfBase64StringOrBytes(string header, string subheader, string title, string FilterHeading, string htmlContent, bool returnBytes, bool pageOrientation)
        {
            //var pdfDoc = new  HtmlToPdfConverter();

            //if (pageOrientation == true)
            //{
            //    pdfDoc.Orientation = PageOrientation.Landscape;
            //}
            //else
            //    pdfDoc.Orientation =PageOrientation.Portrait;
           
           // PageMargins pageMargins = new PageMargins(); //Margins in mm
          //  pageMargins.Bottom = 5;
           // pageMargins.Top = 5;
           // pdfDoc.Margins = pageMargins;
            var style = "<style> table { font-size: 13px;font-family: Open Sans,sans-serif,Arial;} table, tr {page-break-inside: avoid !important;}"
                        + ".LH img {float: left; height: 100px; width: 180px; padding-bottom: 12px; margin-left:-30px} .LH h1 {right:0; position:relative;}</style></br>";
            htmlContent = "<html><head><title></title><meta http-equiv='Content-Type' content='text/html; charset=utf-8' />"
                           + style + "</head><center><div class='LH' > "
                           + "</div></center><body>"
                           + "<center>" + htmlContent + "</center></body></html>";
            //pdfDoc.PageFooterHtml = "<div style='float:right'>  Page <span class='page'></span> of  <span class='topage'></span></div>";
            // byte[] pdfBytes = pdfDoc.GeneratePdf(htmlContent);
            //  byte[] pdfBytes = null;


            string Base64 = ConvertHtmlToPdfBase64(htmlContent);

            return Base64;

        }
        //public static dynamic GetPdfBase64StringOrBytesNew(string sheetName, String header, int columnCount, String Filter, dynamic list)
        //{
        //          string Base64 = string.Empty;


        //	using (var memoryStream = new MemoryStream())
        //	{
        //		// Create a PdfWriter that writes to the memory stream
        //		using (var writer = new PdfWriter(memoryStream))
        //		{
        //			using (var pdf = new PdfDocument(writer))
        //			{
        //				var document = new Document(pdf);

        //				// Add header (optional, based on your requirements)
        //				if (!string.IsNullOrEmpty(header))
        //				{
        //					document.Add(new Paragraph(header).SetBold().SetFontSize(14));
        //				}

        //				// Convert list items to Paragraphs and add them to the document

        //			//var paragraphs = list
        //			//	.Where(item => item != null) // Filter out null items
        //			//	.Select(item => new Paragraph(item))
        //			//	.ToList(); // Convert to list to iterate

        //			//	// Add paragraphs to document
        //			//	foreach (var paragraph in paragraphs)
        //			//	{
        //			//		document.Add(paragraph);
        //			//	}

        //				document.Close();
        //			}
        //		}

        //		// Return the PDF as a Base64 string or bytes
        //		byte[] pdfBytes = memoryStream.ToArray();
        //		Base64= Convert.ToBase64String(pdfBytes);
        //              return Base64;
        //	}

        //}
        public static dynamic GetPdfBase64StringOrBytesNew(string sheetName, string header, int columnCount, string filter, dynamic list)
        {
            //string base64 = string.Empty;
            return "";
            //try
            //{
            //    if (list != null)
            //    {
            //        // Serialize the list to JSON and deserialize into a DataTable
            //        string json = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            //        System.Data.DataTable dt = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(json);

            //        using (var memoryStream = new MemoryStream())
            //        {
            //            // Create a PdfWriter that writes to the memory stream
            //            using (var writer = new PdfWriter(memoryStream))
            //            {
            //                // Set the page orientation based on the column count
                           
            //                iText.Kernel.Geom.PageSize pageSize = columnCount > 6 ? iText.Kernel.Geom.PageSize.A4.Rotate() // Landscape
            //                    : iText.Kernel.Geom.PageSize.A4;        // Portrait

            //                var pdfDocument = new iText.Kernel.Pdf.PdfDocument(writer);
            //                pdfDocument.SetDefaultPageSize(pageSize);

                           
            //                using (var document = new iText.Layout.Document(pdfDocument))
            //                {
            //                    // Add header if provided
            //                    if (!string.IsNullOrEmpty(header))
            //                    {
            //                        document.Add(new Paragraph(header)
            //                            .SetBold()
            //                            .SetFontSize(13)                                        
            //                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                                    
            //                    }

            //                    // Validate and process the DataTable
            //                    if (dt != null && dt.Rows.Count > 0)
            //                    {
            //                        // Create a table with the same number of columns as the DataTable
            //                        var pdfTable = new iText.Layout.Element.Table(UnitValue.CreatePercentArray(dt.Columns.Count))
            //                            .UseAllAvailableWidth();

            //                        // Add table headers
            //                        foreach (DataColumn column in dt.Columns)
            //                        {
            //                            pdfTable.AddHeaderCell(new Paragraph(column.ColumnName)
            //                                .SetFontSize(9)                                          
            //                                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
            //                        }

            //                        // Add table rows
            //                        foreach (DataRow row in dt.Rows)
            //                        {
            //                            foreach (var cell in row.ItemArray)
            //                            {
            //                                pdfTable.AddCell(new Paragraph(cell?.ToString() ?? string.Empty)
            //                                    .SetFontSize(8)
            //                                    //.SetFont(iText.Commons.Utils.UnicodeScript.DEVANAGARI)
            //                                    .SetFontScript(iText.Commons.Utils.UnicodeScript.DEVANAGARI)
            //                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT));
            //                            }
            //                        }

            //                        // Add the table to the document
            //                        document.Add(pdfTable);
            //                    }

            //                    // Close the document
            //                    document.Close();
            //                }
            //            }

            //            // Convert the PDF to Base64
            //           // var str = Encoding.UTF8.GetBytes(memoryStream.ToArray());
            //            base64 = Convert.ToBase64String(memoryStream.ToArray());
            //        }
            //    }
            //    return base64;
            //}
            //catch (Exception ex)
            //{
            //    // Log or handle the exception as needed
            //    throw new Exception("Error generating PDF: " + ex.Message, ex);
            //}
        }
       
        public static string ExportDataTableToPdf(string sheetName, string header, int columnCount, string filter, dynamic list, Dictionary<string, string> dicColumnNames = null)
        {
            
            string base64 = "";
            //string json = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            //System.Data.DataTable dataTable = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(json);

            //StringBuilder sb = new StringBuilder();
            //sb.Append("<html><body><table border='1' style='width: 100%; border-collapse: collapse;'>");

            //// Add table headers
            //sb.Append("<thead><tr>");
            //sb.Append(string.Join("", dicColumnNames
            //    .Select(column => $"<th style='padding: 8px; text-align: left; background-color: #f2f2f2;'>{column.Value}</th>")));
            //sb.Append("</tr></thead>");

            //// Add table rows
            //sb.Append("<tbody>");
            //sb.Append(string.Join("", dataTable.Rows.Cast<DataRow>()
            //    .Select(row => "<tr>" +
            //        string.Join("", row.ItemArray.Select(cell => $"<td style='padding: 8px;'>{cell}</td>")) +
            //        "</tr>")));
            //sb.Append("</tbody>");

            //sb.Append("</table></body></html>");
            //string htmlContent = sb.ToString();


            //var pdfDoc = new HtmlToPdfConverter();
            //if (columnCount> 5)
            //{
            //    pdfDoc.Orientation = (NReco.PdfGenerator.PageOrientation)PageOrientation.Landscape;
            //}
            //else
            //    pdfDoc.Orientation = (NReco.PdfGenerator.PageOrientation)PageOrientation.Portrait;

            //PageMargins pageMargins = new PageMargins(); //Margins in mm
            //pageMargins.Bottom = 5;
            //pageMargins.Top = 5;
            //pdfDoc.Margins = pageMargins;
            //var style = "<style> table { font-size: 13px;font-family: Open Sans,sans-serif,Arial;} table, tr {page-break-inside: avoid !important;}"
            //            + ".LH img {float: left; height: 100px; width: 180px; padding-bottom: 12px; margin-left:-30px} .LH h1 {right:0; position:relative;}</style></br>";
            //htmlContent = "<html><head><title></title><meta http-equiv='Content-Type' content='text/html; charset=utf-8' />"
            //               + style + "</head><center><div class='LH'style='font-size: 16px;' >Rajasthan Sampark 2.0  "
            //               + "</div></center><body>"
            //               + "<center>" + htmlContent + "</center></body></html>";
            //pdfDoc.PageFooterHtml = "<div style='float:right'>  Page <span class='page'></span> of  <span class='topage'></span></div>";
            //byte[] pdfBytes = pdfDoc.GeneratePdf(htmlContent);

            //base64= Convert.ToBase64String(pdfBytes, 0, pdfBytes.Length);
            return base64;
        }
        public static string GetFileFromHtmlDataExcelNew(string sheetName, String header , int columnCount , String Filter,dynamic list)
		{
			string Base64 = "";
			try
			{		// Changes by Giriraj Mali				
					var stream = new MemoryStream();
					ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
					using (var package = new ExcelPackage(stream))
					{
						var worksheet = package.Workbook.Worksheets.Add(sheetName);
					//worksheet.Cells["A1:E1"].Style.Font.Bold = true;
					worksheet.Cells[1,1,1, columnCount].Style.Font.Bold = true;
					worksheet.Cells[1, 1, 1, columnCount].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
					worksheet.Cells.LoadFromCollection(list, true);

						//***************************************** Header Start ****************************************
						worksheet.InsertRow(1, 1); // Inserts 1 row before row 2
                        worksheet.Cells[1, 1].Value = header;
						worksheet.Cells[1, columnCount].Value = "";
						// Merge cells from A1 to E1
						worksheet.Cells[1, 1, 1, columnCount].Merge = true;
						// Set font bold for the merged cells
						worksheet.Cells[1, 1, 1, columnCount].Style.Font.Bold = true;
						worksheet.Cells[1, 1, 1, columnCount].Style.Font.Size = 13;
						// Optional: Set text alignment for the merged cells
						worksheet.Cells[1, 1, 1, columnCount].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
						worksheet.Cells[1, 1, 1, columnCount].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    //***************************************** End ****************************************

                    if (!string.IsNullOrEmpty(Filter))
                    {
						//***************************************** Filter Start ****************************************
						worksheet.InsertRow(2, 1); 
						worksheet.Cells[2, 1].Value = Filter;
						worksheet.Cells[2, columnCount].Value = "";
						// Merge cells from A1 to E1
						worksheet.Cells[2, 1, 2, columnCount].Merge = true;
						// Set font bold for the merged cells
						worksheet.Cells[2, 1, 2, columnCount].Style.Font.Bold = true;
						worksheet.Cells[2, 1, 2, columnCount].Style.Font.Size = 11;
						//// Optional: Set text alignment for the merged cells
						worksheet.Cells[2, 1, 2, columnCount].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
						worksheet.Cells[2, 1, 2, columnCount].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
						//***************************************** End ****************************************

					}



					//***********************Column With Fix **********************************

					worksheet.Columns[1, columnCount].Width = 30;
					//***********************Column With Fix **********************************

					//****** Set the height of the first row
					worksheet.Row(1).Height = 20; // Row 1 height
                                                  //******

                    var usedRange = worksheet.Cells[worksheet.Dimension.Address];
                    foreach (var cell in usedRange)
                    {
                        cell.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        cell.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        cell.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        cell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    }

                    package.Save();
					}
					stream.Position = 0;
					//string excelName = $""+ sheetName +"-{DateTime.Now:yyyyMMddHHmmssfff}.xls";
				    //File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
					Base64 = Convert.ToBase64String(stream.ToArray());				
			}
			catch (Exception ex)
			{

				throw ex;
			}
			return Base64;
		}
      
        public static string GetFileFromHtmlDataExcel(string htmlContent, String header = "",  String Title = "", String FilterHeading = "", bool pageOrientation = false)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                //sb.Append("<table cellpadding='3'  width=100% border=1 style='border-collapse:collapse;'>");
                //sb.Append("<thead>");
                //sb.Append("<tr >");
                //sb.Append("<td style='text-align: center;display:table-cell; padding-bottom:20px; margin-bottom:20px;' >" + header + "</td>");
                //sb.Append("</tr>");
                //if (!string.IsNullOrEmpty(FilterHeading))
                //{
                //    sb.Append("<tr >");
                //    sb.Append("<td style='text-align: left;display:table-cell; padding-bottom:20px; margin-bottom:20px;' >" + FilterHeading + "</td>");
                //    sb.Append("</tr>");
                //}
                //sb.Append("</thead>");
                //sb.Append("</table>");

                var style = "<style> table { font-size: 13px;font-family: Open Sans,sans-serif,Arial;} table, tr {page-break-inside: avoid !important;}"
                            + ".LH img {float: left; height: 100px; width: 180px; padding-bottom: 12px; margin-left:-30px} .LH h1 {right:0; position:relative;}</style></br>";
                htmlContent = "<html><head><title></title><meta http-equiv='Content-Type' content='text/html; charset=utf-8' />"
                               + style + "</head><center><div class='LH' >"
                               + "</div></center><body>"
                               + "<center>"+  htmlContent + "</center></body></html>";

                string htmlContentNew = htmlContent;

                //string base64String = string.Empty; //Encoding.UTF8.GetBytes
                byte[] bt = Encoding.ASCII.GetBytes(htmlContentNew);
                var dataStream = new MemoryStream(bt);
                string Base64=Convert.ToBase64String(dataStream.ToArray());
                //response.Content = new StreamContent(dataStream);
                //response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                //response.Content.Headers.ContentDisposition.FileName = fileNameWithExtension;
                ////Set the File Content Type.
                //response.Content.Headers.ContentType = new MediaTypeHeaderValue(MimeMapping.GetMimeMapping(fileNameWithExtension));

                return Base64;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public static string ConvertHtmlToPdfBase64(string htmlContent)
        {
            using (var stream = new MemoryStream())
            {
                
                //HtmlConverter.ConvertToPdf(htmlContent, stream);
                byte[] pdfBytes = stream.ToArray();
                return Convert.ToBase64String(pdfBytes);
            }
        }
        public static Dictionary<string, string> ShowDisplayColumn<T>(IEnumerable<T> postModel)
        {
            //ResponseModel  returnStatus = new ResponseModel(Status.Success);
            try
            {
                Dictionary<string, string> DisplayColumn = new Dictionary<string, string>();
                PropertyInfo[] properties = typeof(T).GetProperties();
                foreach (PropertyInfo pro in properties)
                {
                    var propInfo = typeof(T).GetProperty(pro.Name);
                    var displayNameAttribute = propInfo.GetCustomAttributes(typeof(DisplayNameAttribute), false);
                    var displayName = (displayNameAttribute[0] as DisplayNameAttribute).DisplayName;
                    DisplayColumn.Add(pro.Name, displayName);
                }
                return DisplayColumn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string ExportDataTableToPdfitext7(string sheetName, string header, int columnCount, string filter, dynamic list, Dictionary<string, string> dicColumnNames = null)
        {
          Core.Utils.LogUtility LogUtility = new Core.Utils.LogUtility();
            LogUtility.WriteEventErrorLog(null, "step 1", "","");
            string base64 = "";
            string outputPath = string.Empty;
            try
            {
           
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            System.Data.DataTable dataTable = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(json);

            StringBuilder sb = new StringBuilder();
            sb.Append("<html><body><table border='1' style='width: 100%; border-collapse: collapse;'>");

            // Add table headers
            sb.Append("<thead><tr>");
            sb.Append(string.Join("", dicColumnNames
                .Select(column => $"<th style='padding: 8px; text-align: left; background-color: #f2f2f2;'>{column.Value}</th>")));
            sb.Append("</tr></thead>");

            // Add table rows
            sb.Append("<tbody>");
            sb.Append(string.Join("", dataTable.Rows.Cast<DataRow>()
                .Select(row => "<tr>" +
                    string.Join("", row.ItemArray.Select(cell => $"<td style='word-break: break-all; text-align: left'>{cell}</td>")) +
                    "</tr>")));
            sb.Append("</tbody>");

            sb.Append("</table></body></html>");
            string htmlContent = sb.ToString();

            var style = "<style> table { font-size: 13px;font-family: 'Noto Sans Devanagari', sans-serif;} table, tr {page-break-inside: avoid !important;}"
                        + ".LH img {float: left; height: 100px; width: 180px; padding-bottom: 12px; margin-left:-30px} .LH h1 {right:0; position:relative;}</style></br>";
            htmlContent = "<html><head><title></title><meta http-equiv='Content-Type' content='text/html; charset=utf-8'  />"
                           + style + "</head><center><div class='LH'style='font-size: 16px;' >Rajasthan Sampark 2.0  "
                           + "</div></center><body>"
                           + "<center>" + htmlContent + "</center></body></html>";
                base64= htmlContent;
               // ResponseModel returnStatus = new ResponseModel(Status.Alert);

               // string baseURL = configuration["ServiceURL:CFG"];
               //returnStatus = CallPostWebAPIWithoutSessionSync<dynamic>("Configuration/ConvertToPdfFile", apiRequestModel, URL);


                //LogUtility.WriteEventErrorLog(null, "step 2", "", "");
                //    Random rand = new Random();
                //int randomNumber = rand.Next(0, 101);
                //string FileName = "Sampark" + DateTime.Now.Year+DateTime.Now.Month.ToString("D2") + DateTime.Now.Day.ToString("D2") + DateTime.Now.Second+ randomNumber;

                //   // LogUtility.WriteEventErrorLog(null, "step 3", "", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName);
                //    outputPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "ApiGateways", "Core.RajSampark.ApiGateways.Web", "Image", FileName+".pdf");
                //    //LogUtility.WriteEventErrorLog(null, "step 4", "", outputPath);
                //    string GetHindiFont = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "ApiGateways", "Core.RajSampark.ApiGateways.Web", "Templates", "NotoSansDevanagari-Regular.ttf");
                //    //LogUtility.WriteEventErrorLog(null, "step 5", "","");

                //    ConverterProperties converterProperties = new ConverterProperties();
                //FontProvider fontProvider = new FontProvider();
                //fontProvider.AddStandardPdfFonts(); // Add standard fonts
                //fontProvider.AddFont(GetHindiFont); // Add Hindi font
                //converterProperties.SetFontProvider(fontProvider);
                //// Convert HTML to PDF using iText7
                //using (PdfWriter writer = new PdfWriter(outputPath))
                //{
                //    using (iText.Kernel.Pdf.PdfDocument pdfDoc = new iText.Kernel.Pdf.PdfDocument(writer))
                //    {
                //        pdfDoc.SetDefaultPageSize(new iText.Kernel.Geom.PageSize(iText.Kernel.Geom.PageSize.A4.GetHeight(), iText.Kernel.Geom.PageSize.A4.GetWidth()));

                //        HtmlConverter.ConvertToPdf(htmlContent, pdfDoc,  converterProperties);
                //    }
                //}
                //    LogUtility.WriteEventErrorLog(null, "step 6", "", "");

                //    byte[] fileBytes = System.IO.File.ReadAllBytes(outputPath);
                //base64 = Convert.ToBase64String(fileBytes);
                //// Delete the temporary file
                //System.IO.File.Delete(outputPath);

            }
            catch (Exception ex)
            {
               
                //if (!string.IsNullOrEmpty(outputPath))
                //{
                //    System.IO.File.Delete(outputPath);
                //}
               
            }
            return base64;

        }
    }
    
    public class CustomHeaderSwaggerAttribute : IOperationFilter
    {

        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "AuthId",
                In = ParameterLocation.Header,
                Required = false,
                Schema = new OpenApiSchema
                {
                    Type = "string"
                }
            });
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "AuthKey",
                In = ParameterLocation.Header,
                Required = false,
                Schema = new OpenApiSchema
                {
                    Type = "string"
                }
            });
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "Language",
                In = ParameterLocation.Header,
                Required = false,
                Schema = new OpenApiSchema
                {
                    Type = "string"
                }
            });
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "FormURL",
                In = ParameterLocation.Header,
                Required = false,
                Schema = new OpenApiSchema
                {
                    Type = "string"
                }
            });
        }

    }
}
