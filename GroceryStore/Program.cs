using System;
using System.Collections.Generic;

namespace GroceryStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Inventory = new Dictionary<string, double>
            //{
            //    { "Eggs", 1.98 },
            //    { "Almond Milk", 3.49 },
            //    { "2-pack Ribeye", 17.99 }
            //};

            //foreach(var item in Inventory)
            //{
            //    Console.WriteLine(item);
            //}

            var _inventory = new Inventory();

            _inventory.PrintInventoryList();

            Console.ReadLine();
        }
    }
    public class Inventory
    {
        private Dictionary<string, double> InventoryList = new Dictionary<string, double>
        {
            { "Eggs", 1.98 },
            { "Almond Milk", 3.49 },
            { "2-pack Ribeye", 17.99 }
        };

        public void PrintInventoryList()
        {
            foreach (var item in InventoryList)
            {
                Console.WriteLine($"Item:{item.Key} - ${item.Value}" );
            }
        }
    }
}
