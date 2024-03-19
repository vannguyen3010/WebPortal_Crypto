namespace Bobles_Coin.Models
{
    public class M_cryptocurrency
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public int num_market_pairs { get; set; }
        public DateTime? date_added { get; set; }
        public M_Platform platform { get; set; }
        public M_Quote quote { get; set; }

    }
}
