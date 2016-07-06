using PagingGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagingGroup
{
    public class Calculator
    {
        /// <summary>
        /// 計算群組數值
        /// </summary>
        /// <param name="groupCount">決定幾筆一組</param>
        /// <param name="groupName">決定要計算的欄位</param>
        /// <returns></returns>
        public IEnumerable<int> CalculatorPagingGroup<T>(List<T> source, int groupCount, Func<T, int> selector)
        {
            int index = 0;
            while (index <= source.Count)
            {
                yield return source.Skip(index).Take(groupCount).Sum(selector);
                index += groupCount;
            }
        }

    }
}
