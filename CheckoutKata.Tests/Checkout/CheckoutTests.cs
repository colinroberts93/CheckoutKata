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


        [Fact]
        public void Given_CheckService_AddItemBToBasket_When_Invoked_ExpectedItemBValuesCorrect()
        {
            //Arrange
            var itemB = new Item
            {
                SKU = ItemSkus.ItemBSku,
                Price = ItemPrices.ItemBPrice,
            };

            _sut.AddItemToBasket(itemB);

            //Act

            var result = _sut.CalculateBasketTotal();


            //Assert
            const int expectedBasketItemValue = 15;
            result.Should().Be(expectedBasketItemValue);
        }

        [Fact]
        public void Given_CheckService_AddItemCToBasket_When_Invoked_ExpectedItemCValuesCorrect()
        {
            //Arrange
            var itemA = new Item
            {
                SKU = ItemSkus.ItemCSku,
                Price = ItemPrices.ItemCPrice,
            };

            _sut.AddItemToBasket(itemA);

            //Act

            var result = _sut.CalculateBasketTotal();


            //Assert
            const int expectedBasketItemValue = 40;
            result.Should().Be(expectedBasketItemValue);
        }

        [Fact]
        public void Given_CheckService_AddItemDToBasket_When_Invoked_ExpectedItemDValuesCorrect()
        {
            //Arrange
            var itemA = new Item
            {
                SKU = ItemSkus.ItemDSku,
                Price = ItemPrices.ItemDPrice,
            };

            _sut.AddItemToBasket(itemA);

            //Act

            var result = _sut.CalculateBasketTotal();


            //Assert
            const int expectedBasketItemValue = 55;
            result.Should().Be(expectedBasketItemValue);
        }


    }
}