using System;
using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void Ctor_WhenItemsIsNull_ShouldThrowArgumentNullException()
        {
            // Arrange and Act
            TestDelegate act = () => new GildedRose(null);

            // Assert
            Assert.Throws<ArgumentNullException>(act);
        }

        [Test]
        public void UpdateQuility_ShouldNotChangeItemName()
        {
            // Arrange            
            var anyItem = new Item { Name = "AnyName", SellIn = 0, Quality = 0 };
            var items = new List<Item> { anyItem };
            var gildedRose = new GildedRose(items);
            
            // Act
            gildedRose.UpdateQuality();
            
            // Assert
            Assert.AreEqual("AnyName", anyItem.Name);
        }

        [Test]
        [TestCase("AnyName", 5, 4, 3, 2)]
        [TestCase("AnyName", 51, 50, 7, 6)]
        [TestCase("AnyName", 51, 49, -5, -6)]
        [TestCase("Sulfuras, Hand of Ragnaros", 51, 51, 0, 0)]
        [TestCase("Sulfuras, Hand of Ragnaros", 0, 0, 0, 0)]
        [TestCase("Sulfuras, Hand of Ragnaros", 5, 5, 0, 0)]
        [TestCase("Sulfuras, Hand of Ragnaros", 5, 5, -5, -5)]
        [TestCase("Aged Brie", 5, 6, 5, 4)]
        [TestCase("Aged Brie", 5, 6, 11, 10)]
        [TestCase("Aged Brie", 0, 1, 5, 4)]
        [TestCase("Aged Brie", 50, 50, 5, 4)]
        [TestCase("Aged Brie", 5, 6, 5, 4)]
        [TestCase("Aged Brie", 0, 2, -5, -6)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 5, 7, 7, 6)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 0, 2, 7, 6)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 0, 3, 5, 4)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 51, 51, 5, 4)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 0, 0, 0, -1)]
        public void UpdateQuility_ShouldSetExpectedQualityAndCellIn(string name, int quality, int expectedQuality, int sellIn, int expectedSellIn)
        {
            // Arrange            
            var anyItem = new Item { Name = name, SellIn = sellIn, Quality = quality };
            var items = new List<Item> { anyItem };
            var gildedRose = new GildedRose(items);
            
            // Act
            gildedRose.UpdateQuality();
            
            // Assert
            Assert.AreEqual(expectedQuality, anyItem.Quality, $"For Item '{name}' expected Quility is {expectedQuality} but actual is {anyItem.Quality}");
            Assert.AreEqual(expectedSellIn, anyItem.SellIn, $"For Item '{name}' and Quality { anyItem.Quality} expected SellIn is {expectedSellIn} but actual is {anyItem.SellIn}");
        }
    }
}
