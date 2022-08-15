namespace GildedRoseKata
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }

    public static class ItemExtensions
    {
        public static void DecreaseSellIn(this Item item)
        {
            item.SellIn -= 1;
        }

        public static void IncreaseQuality(this Item item, ItemQualityModifier modifier)
        {
            if (item.Quality == 50) return;

            item.Quality += 1 * modifier.Value;
        }

        public static void DecreaseQuality(this Item item, ItemQualityModifier modifier)
        {
            if (item.Quality == 0) return;

            item.Quality -= 1 * modifier.Value;
        }

        public static void DropQuality(this Item item)
        {
            item.Quality = 0;
        }

        public static bool IsExpired(this Item item)
        {
            return item.SellIn < 0;
        }
    }
}
