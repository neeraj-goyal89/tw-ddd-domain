namespace tw_ddd.tw.ddd.domain
{
    public interface CartEvent
    {
        
    }
    
    public class CartItemAddedEvent:CartEvent
    {
        private readonly string _product;
        private readonly int _quantity;

        public CartItemAddedEvent(string productName, int quantity)
        {
            _product = productName;
            _quantity = quantity;
        }

        public override string ToString()
        {
            return $"[Product Added] Name : {_product}, Quantity: {_quantity}";
        }
    }
    
    public class CartItemRemovedEvent:CartEvent
    {
        private readonly string _product;

        public CartItemRemovedEvent(string productName)
        {
            _product = productName;
        }

        public override string ToString()
        {
            return $"[Product Deleted] Name : {_product}";
        }
    }
}