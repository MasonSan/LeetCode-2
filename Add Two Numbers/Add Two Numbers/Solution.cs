using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_Two_Numbers
{
    public class Solution
    {
        public IEnumerable<int> AddTwoNumbers(IEnumerable<int> number1, IEnumerable<int> number2)
        {
            var result = new List<int>();
            var carry = 0;

            var enumerator1 = number1.GetEnumerator();
            var enumerator2 = number2.GetEnumerator();

            while (enumerator1.MoveNext() && enumerator2.MoveNext())
            {
                result.Add(((enumerator1.Current + enumerator2.Current) % 10) + carry);
                carry = (enumerator1.Current + enumerator2.Current) / 10;
            }

            while (enumerator1.MoveNext())
                result.Add(enumerator1.Current);

            while (enumerator2.MoveNext())
                result.Add(enumerator2.Current);
            
            return result;
        }
    }
}
