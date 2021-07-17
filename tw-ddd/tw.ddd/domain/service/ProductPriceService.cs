using System.Collections.Generic;

namespace tw_ddd.tw.ddd.domain.service
{
    public class ProductPriceService
    {
        private Dictionary<string, Price> _competitorProductPriceMap;
        private float _discount;
        private bool _isInitialized;
        private static ProductPriceService _instance;  
        
        private ProductPriceService () {}
        
        public static ProductPriceService Instance {  
            get {  
                if (_instance == null) {  
                    _instance = new ProductPriceService();  
                }  
                return _instance;  
            }  
        }
        public Price GetPrice(string productName)
        {
            if (!_competitorProductPriceMap.ContainsKey(productName)) return null;
            
            var competitorPrice = _competitorProductPriceMap[productName];
            return new Price(competitorPrice.Currency, CalculateDiscountPrice(competitorPrice.Cost));

        }

        private decimal CalculateDiscountPrice(decimal price)
        {
            return (price * (decimal) (100 - _discount)) / 100;
        }
        
        public void Initialize(Dictionary<string, Price> competitorProductPriceMap, float discount)
        {
            if (!_isInitialized)
            {
                _discount = discount;
                _competitorProductPriceMap = competitorProductPriceMap;
            }

            _isInitialized = true;
        }
    }
}