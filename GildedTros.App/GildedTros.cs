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
        IList<Item> Items;
        public GildedTros(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQualityData()
        { }
    }
}
