namespace GildedRoseKata
{
    using System.Collections.Generic;

    public class GildedRose
    {
        private readonly IList<Item> Items;
        public GildedRose(IList<Item> items) => Items = items;

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                var strategy = UpdateItemStrategyFactory.GetStrategy(item);

                strategy.UpdateItem();
            }
        }
    }
}
