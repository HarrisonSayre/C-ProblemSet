using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class ReorderListSolutioncs
{
    public void ReorderList(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode former = head;
        ListNode latter = slow.next;
        ListNode lastOne = slow.next = null;

        while (latter != null)
        {
            ListNode temp = latter.next;
            latter.next = lastOne;
            lastOne = latter;
            latter = temp;
        }
        latter = lastOne;

        while (latter != null)
        {
            ListNode tempF = former.next;
            ListNode tempL = latter.next;
            former.next = latter;
            latter.next = tempF;
            former = tempF;
            latter = tempL;
        }

    }

}
