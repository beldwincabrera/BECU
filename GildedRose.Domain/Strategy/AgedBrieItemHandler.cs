using GildedRose.Domain.Entities;

namespace GildedRose.Domain.Strategy;
public class AgedBrieItemHandler : IStockItemUpdateHandler
{
    public void Update(Item item)
    {
        if (item.Quality < 50) item.Quality++;

        item.SellIn--;

        if (item.SellIn < 0 && item.Quality < 50) item.Quality++;
    }
}