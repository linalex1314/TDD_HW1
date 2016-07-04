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
        public List<int> CalculatorPagingGroup<T>(List<T> source, int groupCount, string groupName)
        {
            List<int> result = new List<int>();

            int sum = 0;
            int count = 0;

            foreach (var item in source)
            {
                count++;
                sum += (int)GetPropValue(item, groupName);

                if ((count % groupCount == 0) || count == source.Count)
                {
                    result.Add(sum);
                    sum = 0;
                }
            }

            return result;
        }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
}
