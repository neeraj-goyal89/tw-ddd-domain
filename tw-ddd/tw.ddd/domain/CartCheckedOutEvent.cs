using System;
using System.Collections.Generic;

namespace tw_ddd.tw.ddd.domain
{
    public class CartCheckedOutEvent
    {
        private string _orderId;
        private List<CartItem> _cartItemList;
        
        public CartCheckedOutEvent(List<CartItem> cartItemList)
        {
            _orderId = Guid.NewGuid().ToString();
            _cartItemList = cartItemList;
        }

        public List<CartItem> GetItemList()
        {
            return _cartItemList;
        }
        public override string ToString()
        {
            return $"[Order Created] OrderId : {_orderId} ProductsCount : {_cartItemList.Count}";
        }
    }
}