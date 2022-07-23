using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public static class PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            //Input: numRows = 5
            //Output:[[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
            //[1],
            //[1,1],
            //[1,2,1],
            //[1,3,3,1],
            //[1,4,6,4,1]]

            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int> { 1 });

            for (int i = 1; i < numRows; i++)
            {
                IList<int> curRows = new List<int>();
                curRows.Add(1);
                IList<int> prevRows = result[i - 1];

                for (int j = 1; j < i; j++)
                {
                    curRows.Add(prevRows[j - 1] + prevRows[j]);
                }

                curRows.Add(1);
                result.Add(curRows);
            }

            return result;

        }
    }
}
