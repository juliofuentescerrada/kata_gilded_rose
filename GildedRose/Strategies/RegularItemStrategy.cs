namespace GildedRoseKata.Strategies
{
    internal class RegularItemStrategy : UpdateItemStrategy
    {
        public RegularItemStrategy(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            var modifier = ItemQualityModifier.Normal;
            if (Item.IsExpired()) modifier = ItemQualityModifier.Fast;
            Item.DecreaseQuality(modifier);
        }
    }
}
