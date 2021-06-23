using System;

namespace GroceryStore
{
    class Program
    {
        static void Main(string[] args)
        {       
            var _inventory = new Inventory();

            _inventory.PrintInventoryList();

            if (!int.TryParse(Console.ReadLine(), out int itemChoice)) return;

            var purchasedItem = _inventory.GetProduct(itemChoice-1);

            Console.WriteLine($"Thank you for purchasing {purchasedItem.Name} for ${purchasedItem.Price}");
        }
    }
}
