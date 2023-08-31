using N33_T2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N33_T2.Services
{
    public sealed class OnlineStoreInventoryManagement : InventoryManagementService
    {
        private static List<Product> TestProducts = new List<Product>
        {
            new Product("product1", "product1  desc"),
            new Product("product2", "product2  desc")
        };

        public OnlineStoreInventoryManagement() : base(TestProducts){}

        public void DisplayProducts()
        {
            // displaying all products
        }
    }
}
