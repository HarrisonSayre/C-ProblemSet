using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class AddTwoNumbersSolution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

        ListNode start = new ListNode();
        ListNode current = start;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int firstVal = (l1 != null) ? l1.val : 0;
            int secondVal = (l2 != null) ? l2.val : 0;

            int sum = firstVal + secondVal + carry;
            carry = sum / 10;
            sum = sum % 10;
            current.next = new ListNode(sum);
            current = current.next;

            l1 = (l1 != null) ? l1.next : null;
            l2 = (l2 != null) ? l2.next : null;

        }

        return start.next;

    }
}
