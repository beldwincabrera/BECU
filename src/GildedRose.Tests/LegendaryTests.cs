using GildedRose.Console;
using GildedRose.Domain.Entities;
using NUnit.Framework;

namespace GildedRose.Tests;


[TestFixture]
public class LegendaryTest
{
    [Test]
    public void ShouldQualityIsAlways80()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
        var app = new GildedRose<Item>(items);
        var expected = 80;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().Quality, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldSellInNotDecreased()
    {
        //Arrange
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
        var app = new GildedRose<Item>(items);
        var expected = 0;

        //Act
        app.UpdateQuality();

        //Assert
        Assert.That(items.First().SellIn, Is.EqualTo(expected));
    }
}
