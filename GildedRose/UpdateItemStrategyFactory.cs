namespace GildedRoseKata
{
    using GildedRoseKata.Strategies;

    internal static class UpdateItemStrategyFactory
    {
        public static UpdateItemStrategy GetStrategy(Item item)
        {
            return item.Name switch
            {
                "Aged Brie" => new AgedBrieItemStrategy(item),
                "Sulfuras, Hand of Ragnaros" => new LegendaryItemStrategy(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassItemStrategy(item),
                var c when c.ToLowerInvariant().Contains("conjured")  => new ConjuredItemStrategy(item),
                _ => new RegularItemStrategy(item),
            };
        }
    }
}
