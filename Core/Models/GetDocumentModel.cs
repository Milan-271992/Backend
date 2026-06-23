using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class GetDocumentModel
    {
        public string Status { get; set; }
        public string DocID { get; set; }
        public string DocExists { get; set; }
        public string ResponseCode { get; set; }
        public string ErrorMessage { get; set; }
        public GetFilemetadataModel MetaData { get; set; }
        public string fileName { get; set; }
        public Int64? DocSize { get; set; }
        public string response { get; set; }
        public string File { get; set; }
        public int RowNum { get; set; }
        public string DateOfCreated { get; set; }
        public string ConvertFileSize { get; set; }

    }
    public class GetFilemetadataModel
    {
        public string DocName { get; set; }
        public string CreationDate { get; set; }
        public string RDOCUID { get; set; }
        public string DocumentTitle { get; set; }
    }


}
