using Core.Models;
using System.Globalization;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Web;


namespace Core.Utils
{
    public  class CommonUtils
    {
        public  int GetStartEndNo(ApiFilterModel filterModel, int returnType)
        {
            try
            {
                int START_NO = 0;
                int END_NO = 0;
                int temp = 0;
                JsonNode apiParams = JsonSerializer.Deserialize<JsonNode>(filterModel.FilterParams);
                int currentPage = filterModel.CurrentPageNumber > 0 ? filterModel.CurrentPageNumber : 1;
                int pageSize = (int)(filterModel.PageSize != null && filterModel.PageSize > 0 ? filterModel.PageSize : 10);
                temp = currentPage ==1 ? currentPage :(currentPage - 1) * pageSize;
                START_NO = currentPage == 1 ? temp : temp + 1;
                END_NO = currentPage == 1 ? pageSize : temp + pageSize;

                if (returnType == (int)Enums.Page.StartNo)
                {
                    return START_NO;
                }
                else if (returnType == (int)Enums.Page.EndNo)
                {
                    return END_NO;
                }
                return 0;
            }
            catch (Exception ex)
            {
                LogUtility LogUtility = new LogUtility();   LogUtility.WriteEventErrorLog(ex, string.Empty, MethodBase.GetCurrentMethod().DeclaringType.ToString() + "." + MethodBase.GetCurrentMethod().Name, JsonSerializer.Serialize(filterModel));
                return 0;
            }
        }
        public  string ValidString(string value)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return string.Empty; 
                }
                return value.Trim();
            }
            catch (Exception ex)
            {
                LogUtility LogUtility = new LogUtility();   LogUtility.WriteEventErrorLog(ex, string.Empty, MethodBase.GetCurrentMethod().DeclaringType.ToString() + "." + MethodBase.GetCurrentMethod().Name, JsonSerializer.Serialize(value));
                return value; 
            }
        }
        public  DateTime ParseDate(string dateValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dateValue))
                {
                    throw new ArgumentException("Date is null or empty.");
                }

                if (DateTime.TryParseExact(dateValue, "dd-MMM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    return parsedDate;
                }
                else
                {
                    throw new FormatException("Date was not in a correct format.");
                }
            }
            catch (Exception ex)
            {
                LogUtility LogUtility = new LogUtility();   LogUtility.WriteEventErrorLog(ex, string.Empty, MethodBase.GetCurrentMethod().DeclaringType.ToString() + "." + MethodBase.GetCurrentMethod().Name, JsonSerializer.Serialize(dateValue));
                throw;
            }
        }
        public  DateTime? ParseDate2(string dateValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dateValue))
                {
                    return null; 
                }
                if (DateTime.TryParseExact(dateValue, "dd-MMM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    return parsedDate; 
                }
                else
                {
                    return null; 
                }
            }
            catch (Exception ex)
            {
                LogUtility LogUtility = new LogUtility();   LogUtility.WriteEventErrorLog(ex, string.Empty, MethodBase.GetCurrentMethod().DeclaringType.ToString() + "." + MethodBase.GetCurrentMethod().Name, JsonSerializer.Serialize(dateValue));
                return null;
            }
        }

       


    }
}
