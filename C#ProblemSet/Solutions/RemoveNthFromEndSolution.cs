using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class RemoveNthFromEndSolution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {

        int m = 0;
        ListNode tempStart = new ListNode(0, head);
        ListNode left = tempStart;
        ListNode right = head;

        while (m < n)
        {
            right = right.next;
            m++;
        }

        while (right != null)
        {
            left = left.next;
            right = right.next;
        }

        left.next = left.next.next;

        return tempStart.next;


    }
}
