using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserModerateByDistrictModel
    {
        public Int64 districtId { get; set; }
        public Int64 moderateUserId { get; set; }
		public Int64 departmentId { get; set; }
	}

	public class ProfileDataDetailsModel
	{

		public Int64? divisionId { get; set; }
		public string divisionName { get; set; }
		public string divisionNameRegional { get; set; }

		public Int64? districtId { get; set; }
		public string districtName { get; set; }
		public string districtNameRegional { get; set; }

		public Int64 panchayatId { get; set; }
		public string panchayatName { get; set; }
		public string panchayatNameRegional { get; set; }

		public string gramPanchayatNameRegional { get; set; }
		public Int64 gramPanchayatId { get; set; }
		public string gramPanchayatName { get; set; }

		public Int64 villageId { get; set; }
		public string villageName { get; set; }
		public string villageNameRegional { get; set; }

		public Int64 cityId { get; set; }
		public string cityName { get; set; }
		public string cityNameRegional { get; set; }

		public Int64 wardId { get; set; }
		public string wardName { get; set; }
		public string wardNameRegional { get; set; }
		public string mobileNo { get; set; }
		public string ruralUrban { get; set; }
		
		public string ComplaintArea { get; set; }
	}
}
