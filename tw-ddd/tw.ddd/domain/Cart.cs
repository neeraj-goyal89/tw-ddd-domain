using System.Collections.Generic;

namespace tw_ddd.tw.ddd.domain
{
    public class Cart
    {
        private readonly List<CartItem> _cartItemList;
        private readonly List<Product> _deletedProductList = new List<Product>();

        public Cart()
        {
            _cartItemList = new List<CartItem>();
        }

        public void AddProduct(Product product, int quantity = 1)
        {
            _cartItemList.Add(new CartItem(product, quantity));
        }
        
        public bool RemoveProduct(Product product)
        {
            var cartItemToRemove = FindItem(product);
            if (cartItemToRemove == null) 
                return false;
            
            _deletedProductList.Add(cartItemToRemove.GetProduct());
            _cartItemList.Remove(cartItemToRemove);
            return true;

        }
        private CartItem FindItem(Product product)
        {
            foreach (var cartItem in _cartItemList)
            {
                if (cartItem.GetProduct().Equals(product))
                    return cartItem;
            }

            return null;
        }
    }
}