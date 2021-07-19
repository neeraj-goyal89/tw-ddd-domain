using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using tw_ddd.tw.ddd.domain.service;

namespace tw_ddd.tw.ddd.domain
{
    public class Product
    {
        private string _name;
        
        public Price Price { get; }
        
        public int WeightInGms { get; }

        public Product(string name, Price price, int weightInGms)
        {
            _name = name;
            Price = price;
            WeightInGms = weightInGms;
        }

        public string GetName()
        {
            return _name;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Product))
                return false;
            
            return (_name == ((Product)obj)._name);
        }

        public static Product Create(string name)
        {
            return new Product(name, ProductPriceService.Instance.GetPrice(name), 1000);
        }
        public override int GetHashCode()
        {
            return _name.GetHashCode();
        }

        public override string ToString()
        {
            return $"[Product] Name : {_name} Price: {Price.ToString()}";
        }
    }
}