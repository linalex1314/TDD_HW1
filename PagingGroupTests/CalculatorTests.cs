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
            var products = new ProductRepository().products;
            int groupCount = 3;
            string GroupName = "Cost";

            //act
            var actual = target.CalculatorPagingGroup<Product>(products, groupCount, GroupName);
            List<int> expected = new List<int> { 6, 15, 24, 21 };

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void CalGroupCost_groupCount_is_4_groupName_is_revenue_result_should_50_66_60()
        {
            //arrang
            var target = new Calculator();
            var orders = new OrderRepository().orders;
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