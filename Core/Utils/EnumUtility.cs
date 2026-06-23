using System.ComponentModel;
using System.Reflection;

namespace Core.Utils
{
    public  partial class EnumUtility
    {
        public  String GetDescription(System.Enum EnumConstant)
        {
            try
            {
                FieldInfo fi = EnumConstant.GetType().GetField(EnumConstant.ToString());
                if (fi == null)
                    return "";
                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                    return attributes[0].Description.ToString();
                else
                    return EnumConstant.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public  Dictionary<Int32, string> GetEnmList(System.Type pEnumType)
        {
            try
            {
                Dictionary<Int32, string> dic = new Dictionary<int, string>();
                EnumUtility EnumUtility = new EnumUtility();
                foreach (System.Enum enumInstance in System.Enum.GetValues(pEnumType))
                {
                    dic.Add(Convert.ToInt32(enumInstance), EnumUtility.GetDescription(enumInstance));
                }
                return dic;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public  string GetDescriptionFromValue<T>(int value) where T : Enum
        {
            try
            {
                foreach (T enumValue in Enum.GetValues(typeof(T)))
                {
                    if (Convert.ToInt32(enumValue) == value)
                    {
                        return GetDescription(enumValue);
                    }
                }
                return string.Empty;
            }
            catch (Exception)
            {
                throw;
               
            }            
        }
    }
}
