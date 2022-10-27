using GildedRose.Console;
using GildedRose.Domain.Entities;
using NUnit.Framework;

namespace GildedRose.Tests;

[TestFixture]
public class BackStagePassesTests
{
    [Test]
    public void ShouldIncreaseQualityByOne_SellInGreaterThan10()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
        var app = new GildedRose<Item>(items);

        app.UpdateQuality();

        Assert.That(items.First().Quality, Is.EqualTo(21));
    }

    [Test]
    public void ShouldIncreaseQualityByTwo_SellInBetween10And6()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
        var app = new GildedRose<Item>(items);
        var expected = 22;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldIncreaseQualityByTwo_SellInBetween5And0()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
        var app = new GildedRose<Item>(items);
        var expected = 23;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldBeZeroQuality_WhenSellInNegative()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
        var app = new GildedRose<Item>(items);
        var expected = 0;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldNotQualityBeMoreThan50()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 } };
        var app = new GildedRose<Item>(items);
        var expected = 50;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(expected));

        app.UpdateQuality();
        Assert.That(items.First().Quality, Is.EqualTo(expected));
    }
}
