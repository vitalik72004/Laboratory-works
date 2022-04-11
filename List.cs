namespace Console_Lab._1
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    public class BinarySearch
    {
        public static Node push(Node head, int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            return head;
        }
        static Node middleNode(Node start, Node last)
        {
            if (start == null)
                return null;
            Node slow = start;
            Node fast = start.next;
            while (fast != last)
            {
                fast = fast.next;
                if (fast != last)
                {
                    slow = slow.next;
                    fast = fast.next;
                }                    
            }
            return slow;
        }
        public static Node binarySearch(Node head, int value)
        {
            Node start = head;
            Node last = null;

            do
            {
                Node mid = middleNode(start, last);
                if (mid == null)
                    return null;
                if (mid.data == value)
                    return mid;
                else if (mid.data > value)
                {
                    start = mid.next;
                }
                else
                    last = mid;
            } while (last == null || last != start);
            return null;
        }
        static Node middleNode2(Node start, Node last)
        {
            if (start == null)
                return null;
            Node slow = start;
            Node fast = start.next;
            while (fast != last)
            {
                fast = fast.next;
                if (fast != last)
                {
                    fast = fast.next;
                    if (fast != last)
                    {
                        fast = fast.next;
                        if (fast != last)
                        {
                            fast = fast.next;
                            if (fast != last)
                            {
                                fast = fast.next;
                                if (fast != last)
                                {
                                    fast = fast.next;
                                    if (fast != last)
                                    {
                                        slow = slow.next;
                                        fast = fast.next;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return slow;
        }
        public static Node binarySearch2(Node head, int value)
        {
            Node start = head;
            Node last = null;

            do
            {
                Node mid = middleNode2(start, last);
                if (mid == null)
                    return null;
                if (mid.data == value)
                    return mid;
                else if (mid.data > value)
                {
                    start = mid.next;
                }
                else
                    last = mid;
            } while (last == null || last != start);
            return null;
        }
    }
}
