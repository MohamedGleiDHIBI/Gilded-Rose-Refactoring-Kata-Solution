namespace GildedRoseKata.Models
{
    internal class ConjuredItem : IUpdateItemsQuality
    {
        public override void UpdateQuality()
        {
            SellIn--;
            Quality -= SellIn >= 0 ? 2 : 4;
            if (Quality < MinimumQuality)
                Quality = MinimumQuality;
        }
    }
}
