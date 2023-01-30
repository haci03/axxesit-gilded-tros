using System;
using System.Collections.Generic;

namespace GildedTros.App
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Name = Constants.RING_OF_CLEANSENING_CODE, SellIn = 10, Quality = 20},
                new Item {Name = Constants.GOOD_WINE, SellIn = 2, Quality = 0},
                new Item {Name = Constants.ELIXIR_OF_THE_SOLID, SellIn = 5, Quality = 7},
                new Item {Name = Constants.B_DAWG_KEYCHAIN, SellIn = 0, Quality = 80},
                new Item {Name = Constants.B_DAWG_KEYCHAIN, SellIn = -1, Quality = 80},
                new Item {Name = Constants.BACKSTAGE_PASSES_RE_FACTOR, SellIn = 15, Quality = 20},
                new Item {Name =  Constants.BACKSTAGE_PASSES_RE_FACTOR, SellIn = 10, Quality = 49},
                new Item {Name =  Constants.BACKSTAGE_PASSES_FOR_HAXX, SellIn = 5, Quality = 49},
                // these smelly items do not work properly yet
                new Item {Name = Constants.DUPLICATE_CODE, SellIn = 3, Quality = 6},
                new Item {Name = Constants.LONG_METHODS, SellIn = 3, Quality = 6},
                new Item {Name = Constants.UGLY_VARIABLE_NAMES, SellIn = 3, Quality = 6}
            };

            var app = new GildedTros(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQualityData();
            }
        }
    }
}
