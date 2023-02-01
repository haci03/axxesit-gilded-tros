using System.Collections.Generic;

namespace GildedTros.App
{
    static class Constants
    {
        public const string RING_OF_CLEANSENING_CODE = "Ring of Cleansening Code";
        public const string GOOD_WINE = "Good Wine";
        public const string ELIXIR_OF_THE_SOLID = "Elixir of the SOLID";
        public const string B_DAWG_KEYCHAIN = "B-DAWG Keychain";
        public const string BACKSTAGE_PASSES_RE_FACTOR = "Backstage passes for Re:factor";
        public const string BACKSTAGE_PASSES_FOR_HAXX = "Backstage passes for HAXX";
        public const string DUPLICATE_CODE = "Duplicate Code";
        public const string LONG_METHODS = "Long Methods";
        public const string UGLY_VARIABLE_NAMES = "Ugly Variable Names";

    }

    public class GildedTros
    {
        public const int MAXQUALITY = 50;
        public const int MINQUALITY = 0;
        public const int MINSELLIN = 0;
        public const int DOUBLEFROMSELLINDAYORLESS = 10;
        public const int TRIPLEFROMSELLINDAYORLESS = 5;

        IList<Item> Items;
        public GildedTros(IList<Item> Items)
        {
            this.Items = Items;
        }

      

        public void UpdateQualityData()
        {
            for (int itemIndex = 0; itemIndex < Items.Count; itemIndex++)
            {
                int step = 0;
                switch (Items[itemIndex].Name) 
                {
                  
                    case Constants.GOOD_WINE:
                        Items[itemIndex].SellIn = Items[itemIndex].SellIn - 1;
                        if (Items[itemIndex].Quality < MAXQUALITY)
                            Items[itemIndex].Quality = Items[itemIndex].Quality + 1;

                        break;
                    case Constants.RING_OF_CLEANSENING_CODE:
                    case Constants.ELIXIR_OF_THE_SOLID:
                        Items[itemIndex].SellIn = Items[itemIndex].SellIn - 1;
                        if (Items[itemIndex].SellIn >= MINQUALITY)
                            step = 1;
                        else
                            step = 2;//sell date passed, degrade twice 

                         Items[itemIndex].Quality = Items[itemIndex].Quality - step;
                        //quality never negative
                        if (Items[itemIndex].Quality <= MINQUALITY)
                            Items[itemIndex].Quality = MINQUALITY;

                        break;
                    case Constants.DUPLICATE_CODE:
                    case Constants.LONG_METHODS:
                    case Constants.UGLY_VARIABLE_NAMES:
                        //degrade twice 
                        Items[itemIndex].SellIn = Items[itemIndex].SellIn - 1;
                        if (Items[itemIndex].SellIn >= MINQUALITY)
                            step = 2;
                        else
                            step = 4;

                         Items[itemIndex].Quality = Items[itemIndex].Quality - step;
                        //quality never negative
                        if (Items[itemIndex].Quality <= MINQUALITY)
                            Items[itemIndex].Quality = MINQUALITY;

                        break;

                    case Constants.B_DAWG_KEYCHAIN:
                        //do nothing, a legendary item, never has to be sold 
                        break;
                    
                    case Constants.BACKSTAGE_PASSES_RE_FACTOR:
                    case Constants.BACKSTAGE_PASSES_FOR_HAXX:
                        step = 1;//default
                        Items[itemIndex].SellIn = Items[itemIndex].SellIn - 1;
                        if (Items[itemIndex].SellIn <= DOUBLEFROMSELLINDAYORLESS && Items[itemIndex].SellIn > TRIPLEFROMSELLINDAYORLESS)
                        {
                            step = 2;
    }
                        if (Items[itemIndex].SellIn <= TRIPLEFROMSELLINDAYORLESS && Items[itemIndex].SellIn > MINSELLIN)
                        {
                            step = 3;
}

                        Items[itemIndex].Quality = Items[itemIndex].Quality + step;
                        if(Items[itemIndex].SellIn < MINSELLIN)
                            Items[itemIndex].Quality = MINQUALITY;
                        else
                        {
                            if (Items[itemIndex].Quality >= MAXQUALITY)
                                Items[itemIndex].Quality = MAXQUALITY;
                        }
                         break;

                    default:
                        break;
                }

            }
        }
    }
}
