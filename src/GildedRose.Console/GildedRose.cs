using GildedRose.Domain.Entities;
using GildedRose.Domain.Factory;
using Ninject;
using System.Collections.Generic;
using System.Reflection;

namespace GildedRose.Console;

public class GildedRose<T> where T : Item
{
    private readonly IItemUpdateFactory _updateItemFactory;
    private readonly IList<T> _items;

    public GildedRose(IList<T> items)
    {
        //Load Dependencies
        var kernel = new StandardKernel();
        kernel.Load(Assembly.GetExecutingAssembly());
        _updateItemFactory = kernel.Get<IItemUpdateFactory>();

        _items = items;
    }

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            System.Console.WriteLine($"Before: {item.Name} : {item.Quality}");

            var strategy = _updateItemFactory.Create(item);
            strategy.Update(item);

            System.Console.WriteLine($" After: {item.Name} : {item.Quality}");
            System.Console.WriteLine(" ");
        }
    }
}
