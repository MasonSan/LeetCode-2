using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_Two_Numbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode prev = new ListNode(0);
            ListNode result = prev;

            var carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                var current = new ListNode(0);

                var sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
                current.val = sum % 10;
                carry = sum / 10;

                prev.next = current;
                prev = current;
                l1 = l1?.next;
                l2 = l2?.next;
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
