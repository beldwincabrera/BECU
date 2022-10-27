using GildedRose.Console;
using GildedRose.Domain.Entities;
using NUnit.Framework;

namespace GildedRose.Tests;

[TestFixture]
public class ConjuredTests
{
    [Test]
    public void ShouldDegradeQualityByOne_SellInIsPositive()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 20 } };
        var app = new GildedRose<Item>(items);
        var expected = 19;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items[0].Quality, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldDegradeSellInByOne_SellInIsPositive()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 20 } };
        var app = new GildedRose<Item>(items);
        var expected = 9;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items[0].SellIn, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldDegradeQualityTwiceAsFast_SellInIsNegative()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 20 } };
        var app = new GildedRose<Item>(items);
        var expected = 18;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items[0].Quality, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldNeverQualityBeNegative()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 0 } };
        var app = new GildedRose<Item>(items);
        var expected = 0;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(expected));
    }
}
