namespace GildedRoseKata
{
    public class ItemQualityModifier
    {
        public int Value { get; }
        public static readonly ItemQualityModifier Normal = new(1);
        public static readonly ItemQualityModifier Fast = new(2);
        public static readonly ItemQualityModifier Faster = new(3);
        public static readonly ItemQualityModifier Fastest = new(4);

        private ItemQualityModifier(int value) => Value = value;
    }
}
