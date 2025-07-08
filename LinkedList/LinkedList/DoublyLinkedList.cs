class DllNode
{
    public int data; 
    public DllNode next;
    public DllNode prev;

    public DllNode(){}

    public DllNode(int data1)
    {
        data = data1;
        next = null;
        prev = null;
    }
    public DllNode(int data1, DllNode next1, DllNode prev1)
    {
        data = data1;
        next = next1;
        prev = prev1;
    }
}
class DoublyLinkedList()
{
    public void TraverseLL(DllNode head)
    {
        DllNode pointer = head;
        while (pointer != null)
        {
            Console.Write(pointer.data + " -> ");
            pointer = pointer.next;
        }
        Console.WriteLine("");
    }
    public int LengthOfLL(DllNode head)
    {
        DllNode pointer = head;
        int count = 0;
        while (pointer != null)
        {
            count++;
            pointer = pointer.next;
        }
        return count;
    }
    public void InsertAtStart(int val, ref DllNode head, ref DllNode tail)
    {
        DllNode node = new DllNode(val);
        if(head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            head.prev = node;
            node.next = head;
            head = node;
        }
    }
    public void InsertAtEnd(int val, ref DllNode head, ref DllNode tail)
    {
        DllNode node = new DllNode(val);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            node.prev = tail;
            tail = node;
        }
    }
    public void InsertAtKthPosition(int val, int k, int len, ref DllNode head, ref DllNode tail)
    {
        DllNode node = new DllNode(val);
        if (len == 0)
        {
            if (k == 1)
            {
                head = node;
                tail = node;
            }
            else
            {
                Console.WriteLine("Invalid position");
            }
        }
        else
        {
            if (k == 1)
            {
                head.prev = node;
                node.next = head;
                head = node;
            }
            else if (k == len + 1)
            {
                tail.next = node;
                node.prev = tail;
                tail = node;
            }
            else if (k > len + 1)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                DllNode pos = head;
                while (k > 2)
                {
                    pos = pos.next;
                    k--;
                }
                node.next = pos.next;
                node.prev = pos;
                pos.next.prev = node;
                pos.next = node;
            }
        }
    }
    public void DeleteFromStart(ref DllNode head, ref DllNode tail)
    {
        if (head == null)
        {
            Console.WriteLine("There is no value to delete");
        }
        else if(head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            head = head.next;
            head.prev = null;
        }
    }
    public void DeleteFromEnd(ref DllNode head, ref DllNode tail)
    {
        if (head == null)
        {
            Console.WriteLine("There is no value to delete");
        }
        else if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            tail = tail.prev;
            tail.next = null;
        }
    }
    public void DeleteAtKthPosition(int k, int len, ref DllNode head, ref DllNode tail)
    {
        if (head == null)
        {
            Console.WriteLine("There is no value to delete");
        }
        else
        {
            if (len == 1)
            {
                if (k > 1)
                {
                    Console.WriteLine("Invalid position");
                }
                else
                {
                    head = null;
                    tail = null;
                }
            }
            else
            {
                if (k == 1)
                {
                    head = head.next;
                    head.prev = null;
                }
                else if (k == len)
                {
                    tail = tail.prev;
                    tail.next = null;
                }
                else if (k > len)
                {
                    Console.WriteLine("Invalid position");
                }
                else
                {
                    DllNode pos = head;
                    while (k > 2)
                    {
                        pos = pos.next;
                        k--;
                    }
                    pos.next.next.prev = pos;
                    pos.next = pos.next.next;
                }
            }
        }
    }
    //public static void Main(string[] args)
    //{
    //    DllNode head = null;
    //    DllNode tail = null;
    //    DoublyLinkedList obj = new DoublyLinkedList();
    //    Console.WriteLine("Operations in a Doubly LinkedList: ");
    //    Console.WriteLine("1 -> Insert at start, 2 -> Insert at end, 3 -> Insert at Kth position,");
    //    Console.WriteLine("4 -> Delete from start, 5 -> Delete from end, 6 -> Delete from Kth position, 7 -> exit");
    //    while (true)
    //    {
    //        Console.Write("Enter your choice: ");
    //        string input = Console.ReadLine();

    //        switch (input)
    //        {
    //            case "1":
    //                Console.Write("Enter value to insert at start: ");
    //                int val1 = int.Parse(Console.ReadLine());
    //                obj.InsertAtStart(val1, ref head, ref tail);
    //                break;

    //            case "2":
    //                Console.Write("Enter value to insert at end: ");
    //                int val2 = int.Parse(Console.ReadLine());
    //                obj.InsertAtEnd(val2, ref head, ref tail);
    //                break;

    //            case "3":
    //                Console.Write("Enter value to insert: ");
    //                int val3 = int.Parse(Console.ReadLine());
    //                Console.Write("Enter position (k): ");
    //                int k = int.Parse(Console.ReadLine());
    //                int len = obj.LengthOfLL(head);
    //                obj.InsertAtKthPosition(val3, k, len, ref head, ref tail);
    //                break;

    //            case "4":
    //                obj.DeleteFromStart(ref head, ref tail);
    //                break;

    //            case "5":
    //                obj.DeleteFromEnd(ref head, ref tail);
    //                break;

    //            case "6":
    //                Console.Write("Enter position (k) to delete: ");
    //                int k2 = int.Parse(Console.ReadLine());
    //                int len2 = obj.LengthOfLL(head);
    //                obj.DeleteAtKthPosition(k2, len2, ref head, ref tail);
    //                break;

    //            case "7":
    //                Console.WriteLine("Exiting...");
    //                return;

    //            default:
    //                Console.WriteLine("Invalid input. Please try again.");
    //                break;
    //        }

    //        if(head == null)
    //        {
    //            Console.WriteLine("No value to show");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Current Linked List:");
    //            obj.TraverseLL(head);
    //        }
    //    }
    //}
}
