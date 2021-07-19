using System.Collections.Generic;
using tw_ddd.tw.ddd.domain;

namespace tw_ddd.tw.ddd.Order.domain
{
    public class Order
    {
        private List<CartItem> _itemList;

        public void Create(CartCheckedOutEvent cartCheckedOutEvent)
        {
            _itemList = cartCheckedOutEvent.GetItemList();
            
        }
    }
}


// Cart checkout -> Order event raise -> Received at Application service of Order => DomainService to create order 
//  => Calculate the order cost on demand