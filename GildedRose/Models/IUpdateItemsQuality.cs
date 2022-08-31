using GildedRoseKata.Interfaces;
using GildedRoseKata.Models;

namespace GildedRoseKata.Models
{
    public abstract class IUpdateItemsQuality : Item, IItemQuality
    {
        public int MinimumQuality { get; set; } = 0;
        public int MaximumQuality { get; set; } = 50;
        public abstract void UpdateQuality();
    }
}
