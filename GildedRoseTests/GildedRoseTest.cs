using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Models;
using NUnit.Framework;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            NormalItem normalItem = new NormalItem() { Name = "foo", SellIn = 10, Quality = 0 };
            normalItem.UpdateQuality();
            Assert.AreEqual(0, normalItem.Quality);
        }
        [Test]
        public void GildedRose_QualityAlwaysLowerThan50()
        {
            BackstagePassesItem backstagePassesItem = new BackstagePassesItem() { Name = GildedRoseConstants.Backstage, SellIn = 10, Quality = 48 };
            backstagePassesItem.UpdateQuality();
            Assert.AreEqual(50, backstagePassesItem.Quality);
        }
        [Test]
        public void GildedRose_QualityIncrease()
        {
            SulfurasItem sulfurasItem = new SulfurasItem() { Name = GildedRoseConstants.Sulfuras, Quality = 80, SellIn = 15 };
            sulfurasItem.UpdateQuality();
            Assert.AreEqual(80, sulfurasItem.Quality);
        }
        [Test]
        public void GildedRose_QualityNeverDecreases()
        {
            BackstagePassesItem backstagePassesItem = new BackstagePassesItem() { Name = GildedRoseConstants.Backstage, SellIn = 0, Quality = 35 };
            backstagePassesItem.UpdateQuality();
            Assert.AreEqual(0, backstagePassesItem.Quality);
        }
        [Test]
        public void GildedRose_QualityIncreaseTwice_NegativeSellIn()
        {
            AgedBrieItem agedBrieItem = new AgedBrieItem() { Name = GildedRoseConstants.AgedBrie, Quality = 35, SellIn = -1 };
            agedBrieItem.UpdateQuality();
            Assert.AreEqual(37, agedBrieItem.Quality);
        }
        [Test]
        public void GildedRose_QualityIncrease_BackstagePasses()
        {
            BackstagePassesItem backstagePassesItem = new BackstagePassesItem() { Name = GildedRoseConstants.Backstage, SellIn = 15, Quality = 35 };
            backstagePassesItem.UpdateQuality();
            Assert.AreEqual(36, backstagePassesItem.Quality);
        }
        [Test]
        public void GildedRose_QualityIncreaseby2_BackstagePasses10DaysOut()
        {
            BackstagePassesItem backstagePassesItem = new BackstagePassesItem() { Name = GildedRoseConstants.Backstage, SellIn = 10, Quality = 35 };
            backstagePassesItem.UpdateQuality();
            Assert.AreEqual(37, backstagePassesItem.Quality);
        }
        [Test]
        public void GildedRose_QualityIncreaseby3_BackstagePasses5DaysOut()
        {
            BackstagePassesItem backstagePassesItem = new BackstagePassesItem() { Name = GildedRoseConstants.Backstage, SellIn = 5, Quality = 35 };
            backstagePassesItem.UpdateQuality();
            Assert.AreEqual(38, backstagePassesItem.Quality);
        }
        [Test]
        public void GildedRose_QualityDropTo0_BackstagePassesAfterConcert()
        {
            BackstagePassesItem backstagePassesItem = new BackstagePassesItem() { Name = GildedRoseConstants.Backstage, SellIn = 0, Quality = 35 };
            backstagePassesItem.UpdateQuality();
            Assert.AreEqual(0, backstagePassesItem.Quality);
        }
        [Test]
        public void GildedRose_QualityDecreases_NegativeSellIN()
        {
            NormalItem normalItem = new NormalItem() { Name = "foo", SellIn = 0, Quality = 35 };
            normalItem.UpdateQuality();
            Assert.AreEqual(33, normalItem.Quality);
        }
    }
}
