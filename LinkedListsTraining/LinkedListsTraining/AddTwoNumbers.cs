using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining.AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode head = result;
            int carry = 0;

            while(l1 !=null || l2 != null)
            {
                int sum = carry;

                if(l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if(l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                result.next = new ListNode(sum);
                result = result.next;
            }
            return head = head.next;
           // throw new NotImplementedException();
        }
    }
}
