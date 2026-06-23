namespace Core.Models
{
    public class OTPTransactionModel
    {
        public string ReferenceId { get; set; }
        public Int64 Module { get; set; }
        public Int64 Event { get; set; }

		public dynamic Model { get; set; }
	}

    public class UpmOtpTransactionModel
    {
        public string TransactionNumber { get; set; }
        public string Otp { get; set; }
        public string ValidTillDate { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public Int64 IsVerified { get; set; }
        public Int64? IsSent { get; set; }
        public string SentOn { get; set; }
    }


}
