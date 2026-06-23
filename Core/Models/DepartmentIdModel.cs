using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DepartmentIdModel
    {
        public int DepartmentTypeId { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameHindi { get; set; }
    }

    public class DistrictIdModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionNameRegional { get; set; }
    }
	public class SWDepartmentListModel
	{
		public Int64 DepartmentId { get; set; }
		public string DepartmentName { get; set; }
		public string DepartmentNameHindi { get; set; }
		public string Abbriviation { get; set; }
		public Int64? DeptTypeId { get; set; }
		public Int64? DistrictId { get; set; }
		public Int16? IsExtendedLocation { get; set; }
		public Int64? StartLocationTypeId { get; set; }
		public Int16? IsExtendLocType { get; set; }
		public Int16? IsActive { get; set; }
		public Int16? IsDeleted { get; set; }
		public Int16? InspectionIsActive { get; set; }
		public string ExtendedLocName { get; set; }
		public string ExtendedLocNameHindi { get; set; }
		public string IsColDept { get; set; }
	}

    public class InboundOutboundCompleteCall
    {
        public Int64 CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignNameReg { get; set; }
        public string CampaignType { get; set; }
        public Int32? ActivityCount { get; set; }
    }


	public class OutboundTimeLineWisePendency
	{
		public Int64 CampaignId { get; set; }
		public string CampaignName { get; set; }
		public string CampaignNameReg { get; set; }
		public string CampaignType { get; set; }
		public Int32 Today { get; set; }
		public Int32 Yesterday { get; set; }
		public Int32 Weekly { get; set; }
		public Int32 Monthly { get; set; }
		public Int32 PreviousMonth { get; set; }
		public Int32 Yearly { get; set; }
		public Int32 TillDate { get; set; }
	}

}
