
namespace Cryptobotnic.Coinbase.Account
{
    public class AccountHistoryModel
    {
        public AccountHistoryModel()
        {
            Details = new Details();
        }
        public string id { get; set; }
        public string currency { get; set; }
        public string balance { get; set; }
        public string available { get; set; }
        public string hold { get; set; }
        public string profile_id { get; set; }
        public Details Details { get; set; }
    }

    public class Details
    {
        public string order_id { get; set; }
        public string trade_id { get; set; }
        public string product_id { get; set; }
    }
}
