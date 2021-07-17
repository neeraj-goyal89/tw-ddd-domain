using System;
using System.Collections.Generic;
using tw_ddd.tw.ddd.domain;
using tw_ddd.tw.ddd.domain.service;

namespace tw_ddd.tw.ddd
{
    class Program
    {
        static void Main()
        {
            var competitorProductPriceMap = GetCompetitorProductPriceMap();
            ProductPriceService.Instance.Initialize(competitorProductPriceMap, 10);
            
            var cart = new Cart();
            var iPad = Product.Create("IPad Pro");
            var heroInkPen = Product.Create("Hero ink Pen");
            var gmCricketBat = Product.Create("GM Cricket bat");
            
            Console.WriteLine(iPad);
            cart.AddProduct(iPad);
            cart.AddProduct(heroInkPen);
            cart.AddProduct(gmCricketBat, 2);

            cart.RemoveProduct(iPad);
            var cartEventList = cart.GetCartEventList();
            Console.WriteLine(string.Join('\n', cartEventList));
        }

        private static Dictionary<string, Price> GetCompetitorProductPriceMap()
        {
            var competitorProductPriceMap = new Dictionary<string, Price>
            {
                ["IPad Pro"] = new Price("en-Us", 1000),
                ["Hero ink Pen"] = new Price("en-US", 10),
                ["GM Cricket bat"] = new Price("en-US", 100)
            };

            return competitorProductPriceMap;
        }
    }
}