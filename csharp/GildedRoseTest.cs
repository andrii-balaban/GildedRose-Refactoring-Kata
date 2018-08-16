using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
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
    }
}
