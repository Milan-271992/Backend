using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
 
    public class HeadOfficeDetailModel
    {
        public Int64 OfficeId { get; set; }
        public string OfficeName { get; set; }
        public Int64 OfficeTypeId { get; set; }
        public string OfficeTypeName { get; set; }
        public Int64 OfficeLevelId { get; set; }
        public string OfficeLevelName { get; set; }

    }

    public class RecordDelete
    {
        public string Message { get; set; }
    }

    public class OrganizationModel
    {
        public Int32 Id { get; set; }
        public Int32 DepartmentId { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public Int32? IsHeadOffice { get; set; }
        public Int32? OfficeTypeId { get; set; }
        public string OfficeTypeName { get; set; }
        public Int32? OfficeLevel { get; set; }
        public string OfficeLevelName { get; set; }
        public Int32? ParentOfficeId { get; set; }
        public string ParentOffieName { get; set; }
        public string Code { get; set; }
        public string Gstn { get; set; }
        public string Pan { get; set; }
        public string Logo { get; set; }
        public Int32? OrganizationTypeId { get; set; }
        public Int32? GroupTypeId { get; set; }
        public Int32? IsActive { get; set; }
        public OrganizationDetailModel OrgDetailModel { get; set; }
        public List<OrgContactListModel> OrgContactDetailList { get; set; }
        public List<OrgAddressListModel> OrgAddressDetailList { get; set; }
        public List<OrgBankDetailList> OrgBankDetails { get; set; }
    }

    public class OrgBankDetailList
    {
        public Int32 OrgBankDetailId { get; set; }
        public Int32 OfficeId { get; set; }
        public Int32 BankId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public Int32 AccountTypeId { get; set; }
        public string AccountType { get; set; }
        public String IFSCCode { get; set; }

    }
    public class OrgAddressListModel
    {
        public Int64 OrgAddressId { get; set; }
        public Int64 OfficeId { get; set; }
        public string AddressType { get; set; }
        public string Address { get; set; }
        public Int64? StateId { get; set; }
        public Int64? DistrictId { get; set; }
        public string District { get; set; }
        public Int64? BlockId { get; set; }
        public string Block { get; set; }
        public Int64? GramPanchyatId { get; set; }
        public string GramPanchyat { get; set; }
        public Int64? VillageId { get; set; }
        public string Village { get; set; }
        public Int64? CityId { get; set; }
        public string City { get; set; }
        public Int64? WardId { get; set; }
        public string Ward { get; set; }
        public string IsRural { get; set; }
        public Int64? Pincode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class OrgContactListModel
    {
        public Int64 OrgContactDetailId { get; set; }
        public Int64 OfficeId { get; set; }
        public string OfficeInchargeName { get; set; }
        public Int64? DesignationId { get; set; }
        public string Designation { get; set; }
        public string InchargeContactNo { get; set; }
        public string OfficeContactNo { get; set; }
        public string Email { get; set; }
    }
    public class OrganizationDetailModel
    {
        public Int32 OrgDetailId { get; set; }
        public Int32 OfficeId { get; set; }
        public string ServiceTaxNo { get; set; }
        public string CompanyName { get; set; }
        public string Branch { get; set; }
        public string CIN { get; set; }
        public string EffectiveTill { get; set; }
        public string TanNo { get; set; }
        public string PanNo { get; set; }
        public string GstIn { get; set; }
        public Int32? IsCostCenter { get; set; }
        public Int32? IsActive { get; set; }
        public string DlNo { get; set; }
        public string TinNo { get; set; }
        public Int32? GstTypeId { get; set; }
        public string Code { get; set; }
    }
}
