using GildedRose.Domain.Entities;

namespace GildedRose.Domain.Strategy;
public class ConjuredItemHandler : IStockItemUpdateHandler
{
    public void Update(Item item)
    {
        item.SellIn--;

        if (item.Quality > 0) item.Quality--;

        if (item.SellIn < 0 && item.Quality > 0) item.Quality--;
    }
}
