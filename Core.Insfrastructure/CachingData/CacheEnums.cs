using System.ComponentModel;

namespace Core.Insfrastructure.CachingData
{
    public enum CacheKeysApi
    {
        [Description("DepartmentCache")]
        DepartmentCache = 1,
        [Description("MessageModel")]
        MessageModel = 2,
        [Description("UserSession")]
        UserSession = 3,
        [Description("UPMAllDepartment")]
        UPMAllDepartment = 4,
        [Description("UMPAllDivisionMaster")]
        UMPAllDivisionMaster = 5,
        [Description("UMPAllZone")]
        UMPAllZone = 6,
        [Description("UMPAllDemographicHierarchy")]
        UMPAllDemographicHierarchy = 7,
        [Description("UMPAllDemographicHierarchyWard")]
        UMPAllDemographicHierarchyWard = 8,
        [Description("UMPAllLocationTypeMaster")]
        UMPAllLocationTypeMaster = 9,
        [Description("UPMAllUserMaster")]
        UPMAllUserMaster = 10,
        [Description("UPMAllMerged181Query")]
        UPMAllMerged181Query = 11,
        [Description("UPMAllMerged181QueryResult")]
        UPMAllMerged181QueryResult = 12,

        [Description("UPMDListByDeptTypeId")]
        UPMDListByDeptTypeId = 13,
        [Description("UPMDListByAllDepartment")]
        UPMDListByAllDepartment = 14,
        [Description("UPMDListByAllRoleMaster")]
        UPMDListByAllRoleMaster = 15,

    }

    public enum CacheSelection
    {
        InMemory = 1,
        Redis = 2
    }
}
