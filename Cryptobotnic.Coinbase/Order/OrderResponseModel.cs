
namespace Cryptobotnic.Coinbase.Order
{
    public class OrderResponseModel
    {
        public string id { get; set; }
        public string price { get; set; }
        public string size { get; set; }
        public string product_id { get; set; }
        public string side { get; set; }
        public string stp { get; set; }
        public string type { get; set; }
        public string time_in_force { get; set; }
        public bool post_only { get; set; }
        public string created_at { get; set; }
        public string fill_fees { get; set; }
        public string filled_size { get; set; }
        public string executed_value { get; set; }
        public string status { get; set; }
        public bool settled { get; set; }
    }
}
