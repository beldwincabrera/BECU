using GildedRose.Console;
using GildedRose.Domain.Entities;
using NUnit.Framework;

namespace GildedRose.Tests;

[TestFixture]
public class AgedBrieTests
{
    [Test]
    public void ShouldIncreaseQualityByOne_SellInIsPositive()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 0 } };
        var app = new GildedRose<Item>(items);

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(1));
    }

    [Test]
    public void ShouldIncreaseQualityByTwo_SellInIsZeroOrNegative()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
        var app = new GildedRose<Item>(items);

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(2));
    }

    [Test]
    public void ShouldNotQualityBeMoreThan50()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 } };
        var app = new GildedRose<Item>(items);

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(50));

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(50));
    }

}
