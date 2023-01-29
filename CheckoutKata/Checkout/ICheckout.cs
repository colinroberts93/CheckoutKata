using System.Collections.Generic;
using CheckoutKata.ShoppingItem.Item;

namespace CheckoutKata.Checkout
{
    public interface ICheckout
    {
        public List<Item> BasketItems { get; }
        public void AddItemToBasket(Item item);
        decimal CalculateBasketTotal();
    }
}
