using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagingGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            List<Product> products = new ProductRepository().products;
            IEnumerable<int> result = calculator.CalculatorPagingGroup<Product>(products, 3, x => x.Cost);

            Console.WriteLine("Product Group");
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=============");
            List<Order> orders = new OrderRepository().orders;
            result = calculator.CalculatorPagingGroup<Order>(orders, 4, x => x.Revenue);

            Console.WriteLine("Order Group");
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
