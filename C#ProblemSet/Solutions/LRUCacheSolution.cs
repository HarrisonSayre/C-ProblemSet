using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class LRUCacheSolution
{
    public class Node
    {
        public int key { get; set; }
        public int value { get; set; }
        public Node prev { get; set; }
        public Node next { get; set; }

        public Node(int value, int key)
        {
            this.key = key;
            this.value = value;
            this.prev = null;
            this.next = null;
        }

    }


    public class LRUCache
    {

        private int capacity;
        private Node left;
        private Node right;
        private Dictionary<int, Node> lruCache;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            lruCache = new Dictionary<int, Node>();
            left = new Node(0, 0);
            right = new Node(0, 0);
            left.next = right;
            right.prev = left;
        }

        public void RemoveNode(Node node)
        {
            Node previous = node.prev;
            Node nextOne = node.next;
            previous.next = nextOne;
            nextOne.prev = previous;
        }

        public void InsertNode(Node node)
        {
            Node previous = right.prev;
            previous.next = node;
            node.prev = previous;
            node.next = right;
            right.prev = node;
        }

        public int Get(int key)
        {
            if (lruCache.ContainsKey(key))
            {
                Node node = lruCache[key];
                RemoveNode(node);
                InsertNode(node);
                return node.value;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (lruCache.ContainsKey(key))
            {
                RemoveNode(lruCache[key]);
            }
            Node insertedNode = new Node(value, key);
            lruCache[key] = insertedNode;
            InsertNode(insertedNode);

            if (lruCache.Count > capacity)
            {
                Node leastUsed = left.next;
                RemoveNode(leastUsed);
                lruCache.Remove(leastUsed.key);
            }

        }
    }

}
