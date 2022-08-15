namespace GildedRoseKata
{
    internal abstract class UpdateItemStrategy
    {
        protected readonly Item Item;

        protected UpdateItemStrategy(Item item) => Item = item;

        protected virtual void UpdateSellIn() => Item.DecreaseSellIn();

        protected abstract void UpdateQuality();

        public void UpdateItem()
        {
            UpdateSellIn();
            UpdateQuality();
        }
    }
}
