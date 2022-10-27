using GildedRose.Console;
using GildedRose.Domain.Entities;
using NUnit.Framework;

namespace GildedRose.Tests;

public class StandardTests
{
    [Test]
    public void ShouldDegradeQualityByOne_SellInIsPositive()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
        var app = new GildedRose<Item>(items);
        var expected = 19;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldDegradeSellInByOne_SellInIsPositive()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
        var app = new GildedRose<Item>(items);
        var expected = 9;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().SellIn, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldDegradeQualityTwiceAsFast_SellInIsNegative()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 } };
        var app = new GildedRose<Item>(items);
        var expected = 18;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldQualityIsNeverNegative()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0 } };
        var app = new GildedRose<Item>(items);
        var expected = 0;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(expected));
    }
}
