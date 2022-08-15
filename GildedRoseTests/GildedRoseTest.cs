namespace GildedRoseTests
{
    using Xunit;
    using System.Collections.Generic;
    using GildedRoseKata;

    public class GildedRoseTest
    {

        [Fact]
        public void the_item_quality_should_lower_at_the_end_of_the_day()
        {
            var item = new Item { Name = "+5 Dexterity item", SellIn = 10, Quality = 20 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(9, item.SellIn);
            Assert.Equal(19, item.Quality);
        }

        [Fact]
        public void the_item_quality_should_lower_twice_as_fast_when_expired()
        {
            var item = new Item { Name = "+5 Dexterity item", SellIn = 0, Quality = 20 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(18, item.Quality);
        }

        [Fact]
        public void the_item_quality_should_never_be_negative()
        {
            var item = new Item { Name = "+5 Dexterity item", SellIn = 0, Quality = 0 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void the_aged_brie_quality_should_increase_at_the_end_of_the_day()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(1, item.SellIn);
            Assert.Equal(1, item.Quality);
        }

        [Fact]
        public void the_aged_brie_quality_should_increase_twice_as_fast_when_expired()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(2, item.Quality);
        }

        [Fact]
        public void the_item_quality_should_never_be_greater_than_fifty()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(1, item.SellIn);
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void legendary_items_properties_dont_change()
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(0, item.SellIn);
            Assert.Equal(80, item.Quality);
        }

        [Fact]
        public void the_backstage_passes_quality_should_increase_at_the_end_of_the_day()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 10 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(19, item.SellIn);
            Assert.Equal(11, item.Quality);
        }

        [Fact]
        public void the_backstage_passes_quality_should_increase_twice_as_fast_when_10_or_less_days_left()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(9, item.SellIn);
            Assert.Equal(12, item.Quality);
        }

        [Fact]
        public void the_backstage_passes_quality_should_increase_three_times_as_fast_when_5_or_less_days_left()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(4, item.SellIn);
            Assert.Equal(13, item.Quality);
        }

        [Fact]
        public void the_backstage_passes_quality_should_drop_to_0_when_expired()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 80 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void the_item_quality_should_lower_twice_as_fast_if_conjured()
        {
            var item = new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(2, item.SellIn);
            Assert.Equal(4, item.Quality);
        }

        [Fact]
        public void the_item_quality_should_lower_twice_as_fast_if_conjured_and_expired()
        {
            var item = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 6 };
            GildedRose app = new(new List<Item> { item });

            app.UpdateQuality();

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(2, item.Quality);
        }
    }
}
