using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Core.Utils
{
#nullable disable
    public  class BaseDbUtility
    {
       
        public  object ExecuteScaller(String pCommandText, dynamic context)
        {
            try
            {
                string ret = context.Database.SqlQuery<string>(pCommandText).FirstOrDefault();
                return ret;
            }
            catch (Exception)
            {
                throw;
            }
        }
      
        public  DataTable GetDataTableNew(string SQL, string connectsionString)
        {
            // Added new by Giriraj Mali
            DataSet ds = new DataSet();
            using (var connection = new OracleConnection(connectsionString))
            {
                connection.Open();
                var DA = new OracleDataAdapter(SQL, connection);
                DA.Fill(ds, "tbl");
                connection.Close();
                //connection.Dispose();
                return (DataTable)ds.Tables["tbl"];

            }
            
        }
      
    }
}
