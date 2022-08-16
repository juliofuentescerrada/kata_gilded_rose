namespace GildedRoseKata.Strategies
{
    internal class AgedBrieItemStrategy : UpdateItemStrategy
    {
        public AgedBrieItemStrategy(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            var modifier = ItemQualityModifier.Normal;
            if (Item.IsExpired()) modifier = ItemQualityModifier.Fast;
            Item.IncreaseQuality(modifier);
        }
    }
}
