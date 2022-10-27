using GildedRose.Domain.Factory;
using GildedRose.Domain.Strategy;
using Ninject.Modules;

namespace GildedRose.Console
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            //Factory
            Bind<IItemUpdateFactory>().To<ItemUpdateFactory>().InSingletonScope();

            //Strategy
            Bind<IStockItemUpdateHandler>().To<AgedBrieItemHandler>().InTransientScope();
            Bind<IStockItemUpdateHandler>().To<BackStageItemHandler>().InTransientScope();
            Bind<IStockItemUpdateHandler>().To<ConjuredItemHandler>().InTransientScope();
            Bind<IStockItemUpdateHandler>().To<LegendaryItemHandler>().InTransientScope();
            Bind<IStockItemUpdateHandler>().To<StandardItemHandler>().InTransientScope();
        }
    }
}
