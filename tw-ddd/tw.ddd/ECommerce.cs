using tw_ddd.tw.ddd.domain;

namespace tw_ddd.tw.ddd
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            var iPad = new Product("IPad Pro");
            var heroInkPen = new Product("Hero ink Pen");
            var gmCricketBat = new Product("GM Cricket bat");
            
            cart.AddProduct(iPad);
            cart.AddProduct(heroInkPen);
            cart.AddProduct(gmCricketBat, 2);

            cart.RemoveProduct(iPad);
        }
    }
}