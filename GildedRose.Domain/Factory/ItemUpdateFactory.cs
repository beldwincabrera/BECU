using GildedRose.Domain.Common;
using GildedRose.Domain.Entities;
using GildedRose.Domain.Strategy;

namespace GildedRose.Domain.Factory;
public class ItemUpdateFactory : IItemUpdateFactory
{
    public IStockItemUpdateHandler Create(Item item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        return item.Name switch
        {
            Constants.ItemNames.AgedBrie => new AgedBrieItemHandler(),
            Constants.ItemNames.BackStage => new BackStageItemHandler(),
            Constants.ItemNames.Legendary => new LegendaryItemHandler(),
            Constants.ItemNames.Conjured => new ConjuredItemHandler(),
            _ => new StandardItemHandler(),
        };
    }
}
