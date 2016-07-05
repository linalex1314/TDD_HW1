using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PagingGroup.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void CalGroupCost_groupCount_is_3_groupName_is_cost_result_should_6_15_24_21()
        {
            //arrang
            var target = new Calculator();

            var products = new List<Product>();

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

            int groupCount = 3;
            string GroupName = "Cost";

            //act
            var actual = target.CalculatorPagingGroup<Product>(products, groupCount, GroupName);
            List<int> expected = new List<int> { 6, 15, 24, 21 };

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void CalGroupRevenue_groupCount_is_4_groupName_is_revenue_result_should_50_66_60()
        {
            //arrang
            var target = new Calculator();

            var orders = new List<Order>();

            orders.Add(new Order { id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            orders.Add(new Order { id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            orders.Add(new Order { id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            orders.Add(new Order { id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            orders.Add(new Order { id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            orders.Add(new Order { id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            orders.Add(new Order { id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            orders.Add(new Order { id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            orders.Add(new Order { id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            orders.Add(new Order { id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            orders.Add(new Order { id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            int groupCount = 4;
            string GroupName = "Revenue";

            //act
            var actual = target.CalculatorPagingGroup<Order>(orders, groupCount, GroupName);
            List<int> expected = new List<int> { 50, 66, 60 };

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}