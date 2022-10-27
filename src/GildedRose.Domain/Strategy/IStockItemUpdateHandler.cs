using GildedRose.Domain.Entities;

namespace GildedRose.Domain.Strategy;
public interface IStockItemUpdateHandler
{
    void Update(Item item);
}
