using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryStore
{
    public class Inventory
    {
        private Dictionary<string, double> InventoryList = new Dictionary<string, double>
        {
            { "Eggs", 1.98 },
            { "Almond Milk", 3.49 },
            { "2-pack Ribeye", 17.99 },
            { "Snickers", 0.85 }
        };

        private IList<Product> _inventoryList = new List<Product>();

        public Inventory()
        {
            SeedInventory();
        }

        private void SeedInventory()
        {
            var _random = new Random();
            var count = 1;
            foreach (var item in InventoryList)
            {
                var product = new Product
                {
                    ItemNo = count,
                    Name = item.Key,
                    Price = item.Value,
                    Quantity = _random.Next(1,5)
                };
                _inventoryList.Add(product);
                count++;
            }
        }

        public void PrintInventoryList()
        {
            Console.Write("{0,-12} {1, -20} {2, 7} {3, 10}\n", "Item Number", "Item", "Price", "Quantity");
            Console.WriteLine("______________________________________________________");
            foreach (var item in _inventoryList)
            {                
                Console.WriteLine("{0,-12} {1, -20} {2, 7} {3, 10}", item.ItemNo, item.Name, item.Price, item.Quantity);
                Console.WriteLine("-------------------------------------------------------");
            }
        }
        /// <summary>
        /// Gets the item at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Returns a KeyValuePair<string, double> object</returns>
        public Product GetProduct(int index)
        {
            return _inventoryList.ElementAt(index);
        }
    }
}
