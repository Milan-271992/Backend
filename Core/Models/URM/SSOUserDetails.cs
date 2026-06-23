using System.Diagnostics;
using System.Runtime.Serialization;

namespace Core.Models.URM
{
#nullable disable
	public class SSOUserDetails
	{
		public string SSOID { get; set; }
		public List<string> roles { get; set; }
		public string aadhaarId { get; set; }
		public string bhamashahId { get; set; }
		public string displayName { get; set; }
		public string bhamashahMemberId { get; set; }
		public string dateOfBirth { get; set; }
		public string gender { get; set; }
		public string mobile { get; set; }
		public string telephoneNumber { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string mailPersonal { get; set; }
		public string postalAddress { get; set; }
		public string postalCode { get; set; }
		public string designation { get; set; }
		public string department { get; set; }
		//public string departmentId { get; set; }
		public string mailOfficial { get; set; }
		public string employeeNumber { get; set; }
		public string firstName { get; set; }
		public string jpegPhoto { get; set; }
		public string lastName { get; set; }
		public string sAMAccountName { get; set; }
		public string oldSSOIDs { get; set; }
		public string janaadhaarId { get; set; }
		public string janaadhaarMemberId { get; set; }
		public string userType { get; set; }
		public string mfa { get; set; }


	}

	public class SSOTokenDetails
	{
		public string sAMAccountName { get; set; }
		public string OldSSOIDs { get; set; }
		public string UserType { get; set; }
		public List<string> Roles { get; set; }
		public string SsoToken { get; set; }

	}
	public class SSoDetails
	{
		public string name { get; set; }
		public string email { get; set; }
		public string phone { get; set; }
		public string SSOID { get; set; }
	}

	public class SSOIncreaseSessionTime
	{
		public bool valid { get; set; }
	}

	public class EmailPassword
	{
		public string Email { get; set; }
		public string Password { get; set; }
	}

	public class CommonSsoLoginModel
	{
		public SSOUserDetails ssoUserDetails { get; set; }
		public SSOTokenDetails ssoTokenDetails { get; set; }
	}

	public class LoginSSoModel
	{
		public Int32 Id { get; set; }
		public string LoginSource { get; set; }
		public string LoginType { get; set; }
		public string LoginId { get; set; }
		//  public string Password { get; set; }
		public string IPAddress { get; set; }
		//  public string MobileNo { get; set; }
		public string SsoId { get; set; }
		//  public string TransactionNumber { get; set; }
		//  public string JanAadharId { get; set; }
		//  public string OTP { get; set; }
	}
	public class SSOLoginWithMobile
	{
		public string AuthId { get; set; }
		public string AuthKey { get; set; }
		public string SsoToken { get; set; }
		public string ComeFrom { get; set; }
		public string RedirectKey { get; set; }
		public string ReactURL { get; set; }
		public string Language { get; set; }
		public int UserType { get; set; }
		public Int64 LoginLogId { get; set; }
		public Int64 UserId { get; set; }
		public string MobileNo { get; set; }
		public Int64 ProfileId { get; set; }
		public SwitchUser SwitchUser { get; set; }
	}
	public class UpdateAuthorization
	{
		public Int32 UserId { get; set; }
		public Int32 LoginLogId { get; set; }
		public Int32 RoleId { get; set; }
		public Int32 TypeId { get; set; }
	}

	public class SwitchUser
	{
		public bool IsSwitchUser { get; set; }
		public int Key { get; set; }
	}

	[Serializable]
	[DataContract]
	public class SSOFirstResponseModel
	{
		[DataMember]
		public string UserDetails { get; set; }
		[DataMember]
		public int ClientId { get; set; }
		[DataMember]
		public string PostUrl { get; set; }
		[DataMember]
		public string RedirectUrl { get; set; }
		[DataMember]
		public string LoginLogId { get; set; }
	}
	[Serializable]
	[DataContract]
	public class SSORequestModel
	{
		[DataMember]
		public string ApiKey { get; set; }
		[DataMember]
		public int OrgId { set; get; }
		[DataMember]
		public APIParam ApiParams { get; set; }
	}

	[Serializable]
	[DataContract]
	public class APIParam
	{
		[DataMember]
		public string UserDetails { get; set; }

		[DataMember]
		public Int64 LoginLogId { get; set; }
	}
	[Serializable]
	[DataContract]
	public class SSOResponseModel
	{
		//[DataMember]
		//public string Message { get; set; }
		//[DataMember]
		//public int ReturnMessage { get; set; }
		//[DataMember]
		//public int Status { get; set; }
		//[DataMember]
		//public string SaveOption { get; set; }
		//[DataMember]
		//public string EntityId { get; set; }
		//[DataMember]
		//public object CustomObject { get; set; }
		//[DataMember]
		//public int TotalRecordCount { get; set; }
		//[DataMember]
		//public int FilteredRecordCount { get; set; }
		[DataMember]
		public Int64 UserId { get; set; }
		[DataMember]
		public string UserName { get; set; }
		[DataMember]
		public string SsoId { get; set; }
		[DataMember]
		public int OrgId { get; set; }
		[DataMember]
		public int UserTypeId { get; set; }
		[DataMember]
		public string UserType { get; set; }
		[DataMember]
		public string RedirectUrl { get; set; }

		[DataMember]
		public Int64 LoginLogId { get; set; }

		[DataMember]
		public string LoginId { get; set; }



	}
	public class AppTokenClaims
	{
		public int ClientId { get; set; }
		public long LoginLogId { get; set; }
		public DateTime ExpiryDate { get; set; }
	}
	[Serializable]
	[DataContract]
	public class LDASSOResponseModel
	{
		[DataMember]
		public string Message { get; set; }
		[DataMember]
		public int ReturnMessage { get; set; }
		[DataMember]
		public int Status { get; set; }
		[DataMember]
		public string SaveOption { get; set; }
		[DataMember]
		public string EntityId { get; set; }
		[DataMember]
		public object CustomObject { get; set; }
		[DataMember]
		public int TotalRecordCount { get; set; }
		[DataMember]
		public int FilteredRecordCount { get; set; }


	}
	public class LDASSOVelidationModel
	{
		public int RedirectKey { get; set; }

		public string BaseURL { get; set; }


		public Int64 SsoLoginLogId { get; set; }



	}
    public class EmitraDetails
    {
        private string _ssoId;

        private string _serviceId;

        private string _emssessionId;

        private string _displayName;

        private string _kioskcode;

        private string _kioskname;

        private string _entitytype;

        private string _district;

        private string _districtcd;

        private string _tehsil;

        private string _tehsilcd;

        private string _village;

        private string _villagecd;

        private string _ward;

        private string _wardcd;

        private string _pincode;

        private string _mobile;

        private string _email;

        private string _lspname;

        private string _para1;

        private string _para2;

        private string _para3;

        private string _para4;

        private string _para5;

        private string _returnurl;

        private string _emitratimestamp;

        private string _ssotoken;

        private string _checksum;

        public string SSOID
        {
            get
            {
                return _ssoId;
            }
            set
            {
                _ssoId = value;
            }
        }

        public string SERVICEID
        {
            get
            {
                return _serviceId;
            }
            set
            {
                _serviceId = value;
            }
        }

        public string EMSSESSIONID
        {
            get
            {
                return _emssessionId;
            }
            set
            {
                _emssessionId = value;
            }
        }

        public string DISPLAYNAME
        {
            get
            {
                return _displayName;
            }
            set
            {
                _displayName = value;
            }
        }

        public string KIOSKCODE
        {
            get
            {
                return _kioskcode;
            }
            set
            {
                _kioskcode = value;
            }
        }

        public string KIOSKNAME
        {
            get
            {
                return _kioskname;
            }
            set
            {
                _kioskname = value;
            }
        }

        public string ENTITYTYPE
        {
            get
            {
                return _entitytype;
            }
            set
            {
                _entitytype = value;
            }
        }

        public string DISTRICT
        {
            get
            {
                return _district;
            }
            set
            {
                _district = value;
            }
        }

        public string DISTRICTID
        {
            get
            {
                return _districtcd;
            }
            set
            {
                _districtcd = value;
            }
        }

        public string TEHSIL
        {
            get
            {
                return _tehsil;
            }
            set
            {
                _tehsil = value;
            }
        }

        public string TEHSILCD
        {
            get
            {
                return _tehsilcd;
            }
            set
            {
                _tehsilcd = value;
            }
        }

        public string VILLAGE
        {
            get
            {
                return _village;
            }
            set
            {
                _village = value;
            }
        }

        public string VILLAGECD
        {
            get
            {
                return _villagecd;
            }
            set
            {
                _villagecd = value;
            }
        }

        public string WARD
        {
            get
            {
                return _ward;
            }
            set
            {
                _ward = value;
            }
        }

        public string WARDCD
        {
            get
            {
                return _wardcd;
            }
            set
            {
                _wardcd = value;
            }
        }

        public string PINCODE
        {
            get
            {
                return _pincode;
            }
            set
            {
                _pincode = value;
            }
        }

        public string MOBILE
        {
            get
            {
                return _mobile;
            }
            set
            {
                _mobile = value;
            }
        }

        public string EMAIL
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string LSPNAME
        {
            get
            {
                return _lspname;
            }
            set
            {
                _lspname = value;
            }
        }

        public string PARAMETER1
        {
            get
            {
                return _para1;
            }
            set
            {
                _para1 = value;
            }
        }

        public string PARAMETER2
        {
            get
            {
                return _para2;
            }
            set
            {
                _para2 = value;
            }
        }

        public string PARAMETER3
        {
            get
            {
                return _para3;
            }
            set
            {
                _para3 = value;
            }
        }

        public string PARAMETER4
        {
            get
            {
                return _para4;
            }
            set
            {
                _para4 = value;
            }
        }

        public string PARAMETER5
        {
            get
            {
                return _para5;
            }
            set
            {
                _para5 = value;
            }
        }

        public string RETURNURL
        {
            get
            {
                return _returnurl;
            }
            set
            {
                _returnurl = value;
            }
        }

        public string EMITRATIMESTAMP
        {
            get
            {
                return _emitratimestamp;
            }
            set
            {
                _emitratimestamp = value;
            }
        }

        public string SSOTOKEN
        {
            get
            {
                return _ssotoken;
            }
            set
            {
                _ssotoken = value;
            }
        }

        public string CHECKSUM
        {
            get
            {
                return _checksum;
            }
            set
            {
                _checksum = value;
            }
        }

        [DebuggerNonUserCode]
        public EmitraDetails()
        {
        }
    }


    public class EmitraChecksum
    {
        private string m_SSOID;

        private string m_SERVICEID;

        private string m_EMITRATIMESTAMP;

        private string m_SSOTOKEN;

        public string SSOID
        {
            get
            {
                return m_SSOID;
            }
            set
            {
                m_SSOID = value;
            }
        }

        public string SERVICEID
        {
            get
            {
                return m_SERVICEID;
            }
            set
            {
                m_SERVICEID = value;
            }
        }

        public string EMITRATIMESTAMP
        {
            get
            {
                return m_EMITRATIMESTAMP;
            }
            set
            {
                m_EMITRATIMESTAMP = value;
            }
        }

        public string SSOTOKEN
        {
            get
            {
                return m_SSOTOKEN;
            }
            set
            {
                m_SSOTOKEN = value;
            }
        }

        [DebuggerNonUserCode]
        public EmitraChecksum()
        {
        }


        public class UpdateProfileModel
        {
            public Int64 ProfileId { get; set; }
            public string Name { get; set; }
            public string NameRegional { get; set; }
            public string Email { get; set; }
            

        }
    }
}
