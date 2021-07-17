namespace tw_ddd.tw.ddd.domain
{
    public class CartItem
    {
        private int _quantity;
        private readonly Product _product;

        public CartItem(Product product, int quantity)
        {
            _product = product;
            this._quantity = quantity;
        }

        public Product GetProduct()
        {
            return _product;
        }
    }
}