using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_Two_Numbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode number1, ListNode number2)
        {
            ListNode prev = new ListNode(0);
            ListNode result = prev;

            var carry = 0;

            while (number1 != null || number2 != null || carry != 0)
            {
                var current = new ListNode(0);

                var sum = (number1 == null ? 0 : number1.val) + (number2 == null ? 0 : number2.val) + carry;
                current.val = sum % 10;
                carry = sum / 10;

                prev.next = current;
                prev = current;
                number1 = number1.next;
                number2 = number2.next;
            }

            return result.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
