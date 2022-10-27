using GildedRose.Domain.Entities;
using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            //Populate Inventory of Items
            IList<Item> Items = GetItems();

            //Setup GildedRose App
            var app = new GildedRose<Item>(Items);

            //Update Quality of Items
            app.UpdateQuality();

            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();
        }

        private static List<Item> GetItems()
        {
            return new List<Item>
            {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
                new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        }
    }

}
