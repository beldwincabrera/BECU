using GildedRose.Domain.Entities;

namespace GildedRose.Domain.Strategy;
public class StandardItemHandler : IStockItemUpdateHandler
{
    public void Update(Item item)
    {
        if (item.Quality > 0) item.Quality--;

        item.SellIn--;

        if (item.SellIn < 0 && item.Quality > 0) item.Quality--;
    }
}