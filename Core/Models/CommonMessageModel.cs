using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CommonMessageModel
    {
        public string Key { get; set; }
        public string En { get; set; }
        public string Hi { get; set; }
    }

    public class CommonMessageListModel
    {
        public List<CommonMessageModel> CommonMessage { get; set; }
    }
}
