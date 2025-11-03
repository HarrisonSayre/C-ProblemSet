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

    public ListNode ReverseListMem1(ListNode head)
    {

        // ListNode prev = null;
        // ListNode curr = head;

        // while(curr != null){
        //     ListNode temp = curr.next;        
        //     curr.next = prev;
        //     prev = curr;
        //     curr = temp;
        // }

        // return prev; 

        if (head == null)
        {
            return null;
        }

        ListNode currentHead = head;
        if (head.next != null)
        {
            currentHead = ReverseList(head.next);
            head.next.next = head;
        }

        head.next = null;
        return currentHead;

    }

}
