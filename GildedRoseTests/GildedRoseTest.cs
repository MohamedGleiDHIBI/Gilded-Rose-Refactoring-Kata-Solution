using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        private Item GenrateItems(string name, int sellIn, int quality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            return Items[0];
        }
        [Test]
        public void GildedRose_QualityAlwaysPositive()
        {
            var Item = GenrateItems("foo", 0, 0);
            Assert.AreEqual(0, Item.Quality);
        }
        [Test]
        public void GildedRose_QualityAlwaysLowerThan50()
        {
            var Item = GenrateItems("Backstage passes to a TAFKAL80ETC concert", 10, 48);
            Assert.AreEqual(50, Item.Quality);
        }
        [Test]
        public void GildedRose_QualityIncrease()
        {
            var Item = GenrateItems("Sulfuras, Hand of Ragnaros", 15, 80);
            Assert.AreEqual(80, Item.Quality);
        }
        [Test]
        public void GildedRose_QualityNeverDecreases()
        {
            var Item = GenrateItems("Backstage passes to a TAFKAL80ETC concert", 0, 35);
            Assert.AreEqual(0, Item.Quality);
        }
        [Test]
        public void GildedRose_QualityIncreaseTwice_NegativeSellIn()
        {
            var Item = GenrateItems("Aged Brie", -1, 35);
            Assert.AreEqual(37, Item.Quality);
        }
        [Test]
        public void GildedRose_QualityIncrease_BackstagePasses()
        {
            var Item = GenrateItems("Backstage passes to a TAFKAL80ETC concert", 15, 35);
            Assert.AreEqual(36, Item.Quality);
        }
        [Test]
        public void GildedRose_QualityIncreaseby2_BackstagePasses10DaysOut()
        {
            var Item = GenrateItems("Backstage passes to a TAFKAL80ETC concert", 10, 35);
            Assert.AreEqual(37, Item.Quality);
        }
        [Test]
        public void GildedRose_QualityIncreaseby3_BackstagePasses5DaysOut()
        {
            var Item = GenrateItems("Backstage passes to a TAFKAL80ETC concert", 5, 35);
            Assert.AreEqual(38, Item.Quality);
        }
        [Test]
        public void GildedRose_QualityDropTo0_BackstagePassesAfterConcert()
        {
            var Item = GenrateItems("Backstage passes to a TAFKAL80ETC concert", 0, 35);
            Assert.AreEqual(0, Item.Quality);
        }
        [Test]
        public void GildedRose_QualityDecreases_NegativeSellIN()
        {
            var Item = GenrateItems("foo", 0, 35);
            Assert.AreEqual(33, Item.Quality);
        }
    }
}
