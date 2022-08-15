namespace GildedRoseKata.Strategies
{
    internal class ConjuredItemStrategy : UpdateItemStrategy
    {
        public ConjuredItemStrategy(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            var factor = ItemQualityModifier.Fast;
            if (Item.IsExpired()) factor = ItemQualityModifier.Fastest;
            Item.DecreaseQuality(factor);
        }
    }
}
