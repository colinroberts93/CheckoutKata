using System.Collections.Generic;
using System.Linq;
using CheckoutKata.ShoppingItem.Item;

namespace CheckoutKata.Checkout
{
    public class CheckoutService : ICheckout
    {
        public List<Item> BasketItems { get; } = new List<Item>();

        public void AddItemToBasket(Item item)
        {
            BasketItems.Add(item);
        }


    }
}