namespace GildedRoseKata.Models
{
    public class NormalItem : IUpdateItemsQuality
    {
        public override void UpdateQuality()
        {
            SellIn--;

            Quality -= SellIn >= 0 ? 1 : 2;

            if (Quality < MinimumQuality)
                Quality = MinimumQuality;
        }
    }
}
