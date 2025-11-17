using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_ProblemSet.Solutions;

public class CopyListWithRandomPointersSolution
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    public Node CopyRandomList(Node head)
    {

        Dictionary<Node, Node> oldListMap = new Dictionary<Node, Node>();

        Node current = head;
        while (current != null)
        {
            Node newNode = new Node(current.val);
            oldListMap[current] = newNode;
            current = current.next;
        }

        current = head;
        while (current != null)
        {
            Console.WriteLine(current.val);
            Node newNode = oldListMap[current];
            if (current.next == null)
            {
                //Console.WriteLine("Huh?");
                newNode.next = null;
            }
            else
            {
                newNode.next = oldListMap[current.next];
                //Console.WriteLine(newNode.next.val);
            }
            if (current.random == null)
            {
                newNode.random = null;
            }
            else
            {
                newNode.random = oldListMap[current.random];
            }
            //Console.WriteLine(current.val);
            current = current.next;
        }

        if (head == null)
        {
            return null;
        }
        else
        {
            return oldListMap[head];
        }
    }
}
