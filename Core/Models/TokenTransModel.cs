namespace Core.Models
{
    public class TokenTransModel : CommonEntityModel
    {
        public Int64 Id { get; set; }
        public Int64 DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameHindi { get; set; }
        public Int64 ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNameHindi { get; set; }
        public Int64? DistrictMasterId { get; set; }
        public string DistrictNameEng { get; set; }
        public string DistrictNameHindi { get; set; }
        public string TokenNo { get; set; }
        public string CurrentStatus { get; set; }
        public string DistrictCode { get; set; }
        public string TransDate { get; set; }
        public Int64? ModeId { get; set; }
        public string WorkFlowId { get; set; }
        public string Remark { get; set; }


    }

    public class TokenTransModel_Old : CommonEntityModel
    {
        public Int64 Id { get; set; }
        public Int64 DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameHindi { get; set; }
        public Int64 ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNameHindi { get; set; }
        public Int64? DistrictMasterId { get; set; }
        public string DistrictNameEng { get; set; }
        public string DistrictNameHindi { get; set; }
        public string TokenNo { get; set; }
        public string CurrentStatus { get; set; }
        public string DistrictCode { get; set; }
        public string TransDate { get; set; }
        public Int64? ModeId { get; set; }
        public Int64? WorkFlowId { get; set; }
        public string Remark { get; set; }


    }

}
