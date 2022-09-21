using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    public class ReverseString
    {
        public void ReverseString1(char[] s)
        {

            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                var temp = s[i];
                s[i++] = s[j];
                s[j--] = temp;
            }
        }
    }
}
