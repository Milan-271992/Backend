namespace Core.Models
{
    public class TokenTransactionModel : CommonEntityModel
    {
        public  Int32 TransId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string TokenData { get; set; }
        public List<TokenTransModel> TokenStatusData { get; set; }
    }
}
