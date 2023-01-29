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

        public decimal CalculateBasketTotal()
        {
            var basketTotalPrice = BasketItems.Sum(basketItem => basketItem.Price * basketItem.Quantity);

            return basketTotalPrice;
        }
    }
}