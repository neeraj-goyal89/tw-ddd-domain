using System.Globalization;

namespace tw_ddd.tw.ddd.domain
{
    public class Price
    {
        public string Currency { get;}
        public decimal Cost { get;}

        public Price(string currency, decimal cost)
        {
            Currency = currency;
            Cost = cost;
        }

        public override string ToString()
        {
            return Cost.ToString("C3", CultureInfo.CreateSpecificCulture(Currency));
        }
    }
}