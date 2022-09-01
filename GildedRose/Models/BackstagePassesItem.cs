namespace GildedRoseKata.Models
{
    public class BackstagePassesItem : IUpdateItemsQuality
    {
        public override void UpdateQuality()
        {
            SellIn--;// SellIn decrease ALways for BackstagePasses

            if (SellIn >= 0)
            {
                if (SellIn >= 5)
                    Quality += SellIn > 10 ? 1 : 2;
                else
                    Quality += 3;// If SellIn Lower than 5 Increase Quality By 3
            }
            else
                Quality = MinimumQuality;

            if (Quality > MaximumQuality)
                Quality = MaximumQuality;
        }
    }
}
