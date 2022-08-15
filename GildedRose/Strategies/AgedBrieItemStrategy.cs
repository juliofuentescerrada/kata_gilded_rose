namespace GildedRoseKata.Strategies
{
    internal class AgedBrieItemStrategy : UpdateItemStrategy
    {
        public AgedBrieItemStrategy(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            var factor = ItemQualityModifier.Normal;
            if (Item.IsExpired()) factor = ItemQualityModifier.Fast;
            Item.IncreaseQuality(factor);
        }
    }
}
