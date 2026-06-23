using Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;


namespace Core.Utils
{
    public  class CommonUtility
    {
        public  String GetRandomNumber(Int32 numberLenght)
        {
            Random random = new();
            String randomNumber = "";
            for (Int32 index = 0; index < numberLenght; index++)
            {
                randomNumber = string.Concat(randomNumber, random.Next(9).ToString());
            }
            return randomNumber;
        }
        public  void GetNameParts(string fullName, out string firstName, out string middleName, out string lastName)
        {
            try
            {
                firstName = lastName = middleName = "";
                string[] arr = fullName.Split(' ');
                if (arr[0] != null)
                    firstName = arr[0];
                if (arr.Length >= 2 && arr[1] != null)
                    lastName = arr[1];
                if (arr.Length >= 3 && arr[2] != null)
                {
                    lastName = arr[2];
                    middleName = arr[1];
                }
            }
            catch (Exception)
            { throw; }

        }
        public  string GetFinacialYear(DateTime? dt = null)
        {
            if (dt == null)
                dt = DateTime.Now;
            int currentYear = dt.Value.Year;//2014
            if (dt.Value.Month < 4)
                currentYear--;
            string returnValue = currentYear.ToString() + "-" + (currentYear + 1).ToString();
            return returnValue;
        }

        public  long GetFinacialYearInNumber(DateTime? dt = null)
        {
            if (dt == null)
                dt = DateTime.Now;
            int currentYear = dt.Value.Year;//2014
            if (dt.Value.Month < 4)
                currentYear--;
            string returnValue = currentYear.ToString() + (currentYear + 1).ToString();
            return Convert.ToInt64(returnValue);
        }
        public  DateTime GetStartDateOfFinancialYear(DateTime? dt = null)
        {
            if (dt == null)
                dt = DateTime.Now;
            int currentYear = dt.Value.Year;
            int currentMonth = dt.Value.Month;
            DateTime startDate;
            if (currentMonth <= 3)
            {
                startDate = new DateTime(currentYear - 1, 4, 1);
            }
            else
            {
                startDate = new DateTime(currentYear, 4, 1);
            }
            return startDate;
        }
        public  DateTime GetEndDateOfFinancialYear(DateTime? dt = null)
        {
            if (dt == null)
                dt = DateTime.Now;
            int currentYear = dt.Value.Year;
            int currentMonth = dt.Value.Month;
            DateTime endDate;
            if (currentMonth <= 3)
            {
                endDate = new DateTime(currentYear, 3, 31);
            }
            else
            {
                endDate = new DateTime(currentYear + 1, 3, 31);
            }
            return endDate;
        }   
        public  ResponseModel GetCommonReturnMessage(ResponseModel model, string masterKey, string msgKey,string language, int cnt = 0)
        {
            //MessageDataModel messageReturnModel = new MessageDataModel();//
            
            //DynamicMessage.GetMessage(msgKey, MessageType.ReturnMsg.ToString());
            StringBuilder sb = new StringBuilder();
            //if (language!=null && (language.ToUpper() == "HI" || language.ToUpper() == "HIN"))
            //    sb.Append(messageMasterModel?.MsgHin + " " + messageReturnModel?.MsgHin);
            //else
            //    sb.Append(messageMasterModel?.MsgEng + " " + messageReturnModel?.MsgEng);

            if (cnt > 0)
            {
                model.Message = cnt + " " + sb.ToString();
            }
            else
            {
                model.Message = sb.ToString();
            }
            return model;
        }

        public  StringBuilder GetMessage(string file, string language, string key)
        {
	            if (language == "eng" || language == "En" || language == "en")
                language = "En";
            else
                language = "Hi";
            StringBuilder sb = new StringBuilder();
            string fileContent = string.Empty;
            string itemKey = string.Empty;
            if (File.Exists(file))
            {
                fileContent = File.ReadAllText(file);
                var lstCommonMessage = JsonConvert.DeserializeObject<CommonMessageListModel>(fileContent);

                foreach (var item in lstCommonMessage.CommonMessage)
                {
                    itemKey = item.Key.ToLower();
                    var properties = item.GetType().GetProperties();
                    if (properties.Length > 0)
                    {
                        foreach (var property in properties)
                        {
                            if (property.Name == language && itemKey == key)
                            {
                                if (language == "En")
                                {
                                    sb.Append(item.En.ToString());
                                }
                                else
                                {
                                    sb.Append(item.Hi.ToString());
                                }
                            }
                            //else if (property.Name == language && item.Key == key)
                            //{
                            //    sb.Append(item.En.ToString());
                            //}
                            else
                            {
                                sb.Append(string.Empty);
                            }
                        }
                    }
                }
            }
            return sb;
        }

       public  List<dynamic> ConvertJsonToDynamicList(string jsonString)
        {
            // Parse the JSON string to a dynamic object
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonString);

            // Convert the dynamic object to a list of dynamic objects
            List<dynamic> dynamicList = new List<dynamic>();

            // Iterate through the properties of the dynamic object and add them to the list
            foreach (var property in ((JObject)jsonObject).Properties())
            {
                dynamicList.Add(new { Key = property.Name, Value = property.Value.ToString() });
            }

            return dynamicList;
        }

        public  string DownloadFile(string filePath)
        {
            try
            {
                byte[] fileContent = File.ReadAllBytes(filePath);
                string base64Data = Convert.ToBase64String(fileContent);
                string dataUrl = $"data:application/octet-stream;base64,{base64Data}";
                return dataUrl;
            }
            catch
            {
                return null;
            }
        }
        public  string GetApplicationStatusColour(string status)
        {
            string retColour = "";
            EnumUtility EnumUtility = new EnumUtility();
            if (status == EnumUtility.GetDescription(Enums.SchemeApplicationStatusColour.Gray))
                retColour = Enums.SchemeApplicationStatusColour.Gray.ToString();
            else if (status == EnumUtility.GetDescription(Enums.SchemeApplicationStatusColour.Blue))
                retColour = Enums.SchemeApplicationStatusColour.Blue.ToString();
            else if (status == EnumUtility.GetDescription(Enums.SchemeApplicationStatusColour.Green))
                retColour = Enums.SchemeApplicationStatusColour.Green.ToString();
            else if (status == EnumUtility.GetDescription(Enums.SchemeApplicationStatusColour.Red))
                retColour = Enums.SchemeApplicationStatusColour.Red.ToString();
            else
                retColour = Enums.SchemeApplicationStatusColour.Black.ToString();

            return retColour;
        }
        public  string GetApplicationStatusBorderColour(string status)
        {
            string retColour = "";
            EnumUtility EnumUtility = new EnumUtility();
            if (status == EnumUtility.GetDescription(Enums.SchemeApplicationStatusBorderColour.Gray))
                retColour = Enums.SchemeApplicationStatusBorderColour.Gray.ToString();
            else if (status == EnumUtility.GetDescription(Enums.SchemeApplicationStatusBorderColour.Blue))
                retColour = Enums.SchemeApplicationStatusBorderColour.Blue.ToString();
            else if (status == EnumUtility.GetDescription(Enums.SchemeApplicationStatusBorderColour.Green))
                retColour = Enums.SchemeApplicationStatusBorderColour.Green.ToString();
            else if (status == EnumUtility.GetDescription(Enums.SchemeApplicationStatusBorderColour.Red))
                retColour = Enums.SchemeApplicationStatusBorderColour.Red.ToString();
            else
                retColour = Enums.SchemeApplicationStatusBorderColour.Black.ToString();

            return retColour;
        }

        #region Useing Sewadwaar
        public  string DecryptSewadwaar(string inputText)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(inputText);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount - 1 + 1];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;
        }

        #endregion

        #region MyRegion
        public  string GetUrlforEncryption(string lnk)
        {
            string url = string.Empty;
            try
            {
                CommonUtility CommonUtility = new CommonUtility();
                string path = lnk.Substring(0, lnk.IndexOf("?"));
                string parameters = lnk.Substring(lnk.IndexOf("?") + 1);
                url = path + Encrypt(parameters);
                
            }
            catch (Exception ex)
            {
                return null;
            }
            return url;
        }
        public  string Encrypt(string inputText)
        {

            string PARAMETER_NAME = "enc=";
            string strmsg = string.Empty;
            byte[] encode = new byte[inputText.Length - 1 + 1];
            encode = Encoding.UTF8.GetBytes(inputText);
            strmsg = Convert.ToBase64String(encode);
            return "?" + PARAMETER_NAME + strmsg;
        }

        #endregion


        public string DecodeIfUnicode(string input)
        {
            // Check if input contains HTML Unicode encoding (like &#115;)
            if (Regex.IsMatch(input, "&#[0-9]+;"))
            {
                return HttpUtility.HtmlDecode(input);
            }
            return input; // Return original if no Unicode encoding found
        }

    }
}
