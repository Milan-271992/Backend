using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
	public class SewadwaarCommonModel
	{
		public  class SWDistirctMaster
		{
			public string DistrictId
			{
				get
				{
					return _DistrictId;
				}
				set
				{
					_DistrictId = value;
				}
			}
			private string _DistrictId;

			public string C_DistrictId
			{
				get
				{
					return _C_DistrictId;
				}
				set
				{
					_C_DistrictId = value;
				}
			}
			private string _C_DistrictId;

			public string Name
			{
				get
				{
					return _Name;
				}
				set
				{
					_Name = value;
				}
			}
			private string _Name;

			public string NameHindi
			{
				get
				{
					return _NameHindi;
				}
				set
				{
					_NameHindi = value;
				}
			}
			private string _NameHindi;
		}

		
	}
	public class GrievanceDetailsRespones
	{
		public Int64 districtid { get; set; }
		public Int64 cityBlockId { get; set; }
		public Int64 grmpId { get; set; }

	}
	public class DocLink
	{
		public string MobileNo { get; set; }
		public Int64 ApplicationId { get; set; }
		public string ServiceType { get; set; }
		public Int64 EntityId { get; set; }
		public int SourceId { get; set; }

	}
	public partial class GetGrievanceWAModelResponse
	{
		public string Status { get; set; }
		public string ResponseMsg { get; set; }
		public string ErrorCode { get; set; }
	}

	public partial class GetGrievanceWAModel
	{

		public string fullname { get; set; }
		public string gender { get; set; }
		public string phone { get; set; }
		public string password { get; set; }
		public string locationtype { get; set; }
		public string state { get; set; }
		public string district { get; set; }
		public string city { get; set; }
		public string GP_WN { get; set; }
		public string village { get; set; }
		public string locationtype1 { get; set; }
		public string state1 { get; set; }
		public string district1 { get; set; }
		public string city1 { get; set; }
		public string GP_WN1 { get; set; }
		public string village1 { get; set; }
		public string g_category { get; set; }
		public string reliefrequired { get; set; }
		public string gridescription { get; set; }
		public string department { get; set; }
		public string subject { get; set; }
		public string gtype { get; set; }
		public string fileAttatchment { get; set; }
		public string request_no { get; set; }
		public string source { get; set; }
		public string requesturl { get; set; }
		public string FileName { get; set; }
		public string FileType { get; set; }
		public string ADDRESS_E_PARA { get; set; }
		public string COMPLAINT_AREA_PARA { get; set; }

	}
    public partial class ComplainantMasterData
    {
        public Int64 complainant_id { get; set; }
        public Int64 pr_phone_no { get; set; }
        public Int64 pincode_no { get; set; }
        public char rural_urban { get; set; }
        public Int64 village_id { get; set; }
        public Int64 gram_panchayat_id { get; set; }
		public ClassDistrict district_id { get; set; }
        public Int64 gender { get; set; }
        public Int64 state_id { get; set; }
        public Int64 country_id { get; set; }
        public string email_id { get; set; }
        public string address_e { get; set; }
        public string father_name_e { get; set; }
        public string c_name_h { get; set; }
        public string c_name_e { get; set; }
        public Int64 panchayat_id { get; set; }
        public string landmark { get; set; }
        public string landmark2 { get; set; }
        public string landmark3 { get; set; }
    }
    public partial class ClassDistrict
    {
        public Int64 DistrictID { get; set; }
        public string DistrictName_H { get; set; }
        public string DistrictName { get; set; }
    }
}
