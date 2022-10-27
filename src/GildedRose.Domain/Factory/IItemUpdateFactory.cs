using GildedRose.Domain.Entities;
using GildedRose.Domain.Strategy;

namespace GildedRose.Domain.Factory;
public interface IItemUpdateFactory
{
    IStockItemUpdateHandler Create(Item item);
}
