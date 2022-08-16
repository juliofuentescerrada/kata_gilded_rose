namespace GildedRoseKata.Strategies
{
    internal class ConjuredItemStrategy : UpdateItemStrategy
    {
        public ConjuredItemStrategy(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            var modifier = ItemQualityModifier.Fast;
            if (Item.IsExpired()) modifier = ItemQualityModifier.Fastest;
            Item.DecreaseQuality(modifier);
        }
    }
}
