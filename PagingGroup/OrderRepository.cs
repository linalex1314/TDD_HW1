using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagingGroup
{
    public class ProductRepository
    {
        public ListGeneric<Product> products { get; set; }
        public ProductRepository()
        {
            products = new ListGeneric<Product>();

            products.Add(new Product { id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            products.Add(new Product { id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            products.Add(new Product { id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            products.Add(new Product { id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            products.Add(new Product { id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            products.Add(new Product { id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            products.Add(new Product { id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            products.Add(new Product { id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            products.Add(new Product { id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            products.Add(new Product { id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            products.Add(new Product { id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

        }

    }
}
