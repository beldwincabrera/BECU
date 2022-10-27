using GildedRose.Domain.Entities;

namespace GildedRose.Domain.Strategy;
public class LegendaryItemHandler : IStockItemUpdateHandler
{
    public void Update(Item item)
    {
        item.SellIn = item.SellIn;
        item.Quality = item.Quality;
    }
}