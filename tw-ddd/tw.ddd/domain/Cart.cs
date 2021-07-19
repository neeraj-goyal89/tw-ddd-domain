using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace tw_ddd.tw.ddd.domain
{
    public class Cart
    {
        public string CartId { get; }
        private readonly List<CartItem> _cartItemList;
        private readonly List<CartEvent> _cartEventList = new List<CartEvent>();

        public Cart()
        {
            _cartItemList = new List<CartItem>();
            CartId = Guid.NewGuid().ToString();
        }

        public void AddProduct(Product product, int quantity = 1)
        {
            _cartEventList.Add(new CartItemAddedEvent(product.GetName(), quantity));
            _cartItemList.Add(new CartItem(product, quantity));
        }
        
        public bool RemoveProduct(Product product)
        {
            var cartItemToRemove = FindItem(product);
            if (cartItemToRemove == null) 
                return false;
         
            _cartEventList.Add(new CartItemRemovedEvent(product.GetName()));
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

        public List<CartEvent> GetCartEventList()
        {
            return _cartEventList;
        }

        public void Checkout()
        {
            RaiseEvent(new CartCheckedOutEvent(_cartItemList));
        }
        
        private void RaiseEvent(CartCheckedOutEvent cartCheckedOutEvent)
        {
            Console.WriteLine(cartCheckedOutEvent.ToString());
        }
    }
}
/*
Order
-> List of products & quantity
-> Calculate Order price
*/