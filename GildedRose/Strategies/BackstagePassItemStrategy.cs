namespace GildedRoseKata.Strategies
{
    internal class BackstagePassItemStrategy : UpdateItemStrategy
    {
        public BackstagePassItemStrategy(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            if (Item.IsExpired())
            {
                Item.DropQuality();
                return;
            }

            var factor = ItemQualityModifier.Normal;
            if (Item.SellIn < 11) factor = ItemQualityModifier.Fast;
            if (Item.SellIn < 6) factor = ItemQualityModifier.Faster;
         
            Item.IncreaseQuality(factor);
        }
    }
}
