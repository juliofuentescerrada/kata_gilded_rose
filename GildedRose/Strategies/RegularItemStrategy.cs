namespace GildedRoseKata.Strategies
{
    internal class RegularItemStrategy : UpdateItemStrategy
    {
        public RegularItemStrategy(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            var factor = ItemQualityModifier.Normal;
            if (Item.IsExpired()) factor = ItemQualityModifier.Fast;
            Item.DecreaseQuality(factor);
        }
    }
}
