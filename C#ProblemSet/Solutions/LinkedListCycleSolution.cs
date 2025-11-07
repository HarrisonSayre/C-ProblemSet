using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class LinkedListCycleSolution
{
    public bool HasCycle(ListNode head)
    {
        ListNode i = head;
        ListNode j = head;

        while (j != null && j.next != null)
        {
            j = j.next.next;
            i = i.next;
            if (i.Equals(j))
            {
                return true;
            }
        }

        return false;

    }
}
