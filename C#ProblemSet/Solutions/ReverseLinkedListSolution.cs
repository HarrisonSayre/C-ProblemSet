namespace C_ProblemSet.Solutions;

public class ReverseLinkedListSolution
{
    public static ListNode ReverseList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        ListNode curHead = head;
        if (curHead.next != null)
        {
            curHead = ReverseList(head.next);
            head.next.next = head;
        }
        head.next = null; 

        return curHead;
    }
}
