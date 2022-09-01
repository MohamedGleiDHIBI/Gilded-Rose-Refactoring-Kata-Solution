using GildedRoseKata.Models;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose: IGildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void Execute()
        {
            Console.WriteLine("OMGHAI!");

            IList<IUpdateItemsQuality> Items = new List<IUpdateItemsQuality>{
                new NormalItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedBrieItem {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new AgedBrieItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new SulfurasItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new SulfurasItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new BackstagePassesItem{ Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 15, Quality = 20},
                new BackstagePassesItem{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 10,Quality = 49},
                new BackstagePassesItem{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 5,Quality = 49},
                new ConjuredItem {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            //var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (var item in Items)
                {
                    Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                    item.UpdateQuality();
                }

                Console.WriteLine("");
            }
        }

        
    }
}
