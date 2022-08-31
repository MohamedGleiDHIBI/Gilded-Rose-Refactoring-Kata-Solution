namespace GildedRoseKata.Models
{
    internal class AgedBrieItem : IUpdateItemsQuality
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;// SellIn decrease ALways for AgedBrie

            if (SellIn >= 0)
                Quality++;// If SellIn Positive Increase Quality By 1
            else
                Quality += 2;//If SellIn negative Increase Quality By 2

            if (Quality > 50)
                Quality = MaximumQuality;  // Quality ALways Lower Than 50 
        }
    }

}
