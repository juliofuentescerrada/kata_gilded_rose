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

            var modifier = ItemQualityModifier.Normal;
            if (Item.SellIn < 11) modifier = ItemQualityModifier.Fast;
            if (Item.SellIn < 6) modifier = ItemQualityModifier.Faster;
         
            Item.IncreaseQuality(modifier);
        }
    }
}
