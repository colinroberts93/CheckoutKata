using System.Collections.Generic;
using CheckoutKata.ShoppingItem;
using CheckoutKata.ShoppingItem.Item;

namespace CheckoutKata.Promotions
{
    class Promotion
    {
        public class ItemBPromotion : PromotionSum
        {
            public override int PromotionQuantityTrigger { get; } = 3;
            public override decimal PromotionDeductionValue { get; } = 5m;
        }

        public class ItemDPromotion : PromotionSum
        {
            public override int PromotionQuantityTrigger { get; } = 2;
            public override decimal PromotionDeductionValue { get; } = 27.5m;
        }


        public abstract class PromotionSum
        {
            public abstract int PromotionQuantityTrigger { get; }
            public abstract decimal PromotionDeductionValue { get; }

            public void ApplyPromotion(Item basketItem, ref decimal basketTotalPrice)
            {
                var applicableDeductions = basketItem.Quantity / PromotionQuantityTrigger;
                if (applicableDeductions <= 0) return;

                var offerDeductionValue = PromotionDeductionValue * applicableDeductions;
                basketTotalPrice -= offerDeductionValue;
            }
        }

        public void ApplyPromotions(List<Item> basketItems, ref decimal basketTotalPrice)
        {
            foreach (var basketItem in basketItems)
            {
                if (basketItem.SKU == ItemSkus.ItemBSku)
                {
                    var itemBPromotion = new ItemBPromotion();
                    itemBPromotion.ApplyPromotion(basketItem, ref basketTotalPrice);
                }

                if (basketItem.SKU != ItemSkus.ItemDSku) continue;
                {
                    var itemDPromotion = new ItemDPromotion();
                    itemDPromotion.ApplyPromotion(basketItem, ref basketTotalPrice);
                }
            }
        }

    }
}
