namespace GildedRoseKata.Strategies
{
    internal class LegendaryItemStrategy : UpdateItemStrategy
    {
        public LegendaryItemStrategy(Item item) : base(item) { }

        protected override void UpdateSellIn() { return; }
        protected override void UpdateQuality() { return; }
    }
}
