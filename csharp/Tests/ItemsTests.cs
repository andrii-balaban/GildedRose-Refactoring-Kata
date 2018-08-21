using csharp;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ItemsTests
    {
        [Test]
        public void IncreaseQuality_ShouldIncreaseItemQualityByOne()
        {
            // Arrange 
            var item = new Item { Quality = 0 };

            // Act
            item.IncreaseQuality();

            // Assert
            Assert.AreEqual(1, item.Quality);
        }

        [Test]
        public void DeacreaseQuality_ShouldDecreaseItemQualityByOne()
        {
            // Arrange 
            var item = new Item { Quality = 2 };

            // Act
            item.DecreaseQuality();

            // Assert
            Assert.AreEqual(1, item.Quality);
        }

        [Test]
        public void ZeroQuality_ShouldSetQualityToZero()
        {
            // Arrange
            var item = new Item { Quality = 121 };

            // Act
            item.ZeroQuality();

            // Assert
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void ToString_ShouldReturnConcatenatedCommaSeparatedPropertyValues()
        {
            // Arrange
            var item = new Item { Name = "AnyName", Quality = 12, SellIn = 43};

            // Act
            string stringValue = item.ToString();

            // Assert
            Assert.AreEqual("AnyName, 43, 12", stringValue);
        }
    }
}
