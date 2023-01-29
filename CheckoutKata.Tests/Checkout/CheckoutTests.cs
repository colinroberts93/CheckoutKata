using CheckoutKata.Checkout;
using CheckoutKata.ShoppingItem;
using CheckoutKata.ShoppingItem.Item;
using FluentAssertions;
using Xunit;

namespace CheckoutKata.Tests.Checkout
{
    public class CheckoutTests
    {
        private readonly CheckoutService _sut;

        public CheckoutTests()
        {
            _sut = new CheckoutService();
        }

        [Fact]
        public void Given_CheckService_AddItemAToBasket_When_Invoked_ExpectedItemAValuesCorrect()
        {
            //Arrange
            var itemA = new Item
            {
                SKU = ItemSkus.ItemASku,
                Price = ItemPrices.ItemAPrice,
            };

            _sut.AddItemToBasket(itemA);

            //Act

            var result = _sut.CalculateBasketTotal();


            //Assert
            const int expectedBasketItemValue = 10;
            result.Should().Be(expectedBasketItemValue);
        }
    }

}