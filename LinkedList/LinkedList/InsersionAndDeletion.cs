using System.Xml.Linq;

class InsersionAndDeletion
{
    public void InsertAtStart(int val, ref Node head, ref Node tail)
    {
        Node node = new Node(val);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            node.next = head;
            head = node;
        }
    }
    public void InsertAtEnd(int val, ref Node head, ref Node tail)
    {
        Node node = new Node(val);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
    }
    public void InsertAtKthPosition(int val, int k, int len, ref Node head, ref Node tail)
    {
        Node node = new Node(val);
        if(len == 0)
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
                node.next = head;
                head = node;
            }
            else if (k == len + 1)
            {
                tail.next = node;
                tail = node;
            }
            else if (k > len + 1)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                Node pos = head;
                while(k > 2)
                {
                    pos = pos.next;
                    k--;
                }
                node.next = pos.next;
                pos.next = node;
            }
        }
    }
    public void InsertAfterX(int val, int x, ref Node head, ref Node tail)
    {
        Node node = new Node(val);
        if(head == null)
        {
            head = node;
            tail = node;
            return;
        }
        Node pointer = head;
        bool isPresent = false;
        while (pointer != null)
        {
            if(pointer.data == x)
            {
                isPresent = true;
                if(pointer.next == null)
                {
                    pointer.next = node;
                    tail = node;
                }
                else
                {
                    node.next = pointer.next;
                    pointer.next = node;
                }
                break;
            }
            pointer = pointer.next;
        }
        if (!isPresent)
        {
            Console.WriteLine("The given value does not exist in the LinkedList");
        }
    }
    public void DeleteAtStart(ref Node head)
    {
        if (head == null)
        {
            Console.WriteLine("There is no value to delete");
        }
        else
        {
            head = head.next;
        }
    }
    public void DeleteAtEnd(ref Node head, ref Node tail)
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
            Node pointer = head;
            while (pointer.next != tail)
            {
                pointer = pointer.next;
            }
            tail = pointer;
            tail.next = null;
        }
    }
    public void DeleteAtKthPosition(int len, int k, ref Node head, ref Node tail)
    {
        if (head == null)
        {
            Console.WriteLine("There is no value to delete");
        }
        else
        {
            if(len == 1)
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
                }
                else if(k==len)
                {
                    Node pointer = head;
                    while (pointer.next != tail)
                    {
                        pointer = pointer.next;
                    }
                    tail = pointer;
                }
                else if (k > len)
                {
                    Console.WriteLine("Invalid position");
                }
                else
                {
                    Node pos = head;
                    while (k > 2)
                    {
                        pos = pos.next;
                        k--;
                    }
                    pos.next = pos.next.next;
                }
            }
        }
    }
    public void DeleteAfterX(int x, ref Node head, ref Node tail)
    {
        if (head == null)
        {
            Console.WriteLine("There is no value to delete");
        }
        Node pointer = head;
        bool isPresent = false;
        while (pointer != null)
        {
            if (pointer.data == x)
            {
                isPresent = true;
                if (pointer.next == null)
                {
                    Console.WriteLine("There is no value to delete");
                }
                else if (pointer.next.next != null)
                {
                    pointer.next = pointer.next.next;
                }
                else
                {
                    tail = pointer;
                    tail.next = null;
                }
                break;
            }
            pointer = pointer.next;
        }
        if (!isPresent)
        {
            Console.WriteLine("The given value does not exist in the LinkedList");
        }
    }

    //public static void Main(string[] args)
    //{
    //    Node head = null;
    //    Node tail = null;
    //    InsersionAndDeletion obj = new InsersionAndDeletion();
    //    ArrayToLL obj1 = new ArrayToLL();
    //    Console.WriteLine("Operations in a LinkedList: ");
    //    Console.WriteLine("1 -> Insert at start, 2 -> Insert at end, 3 -> Insert at Kth position, 4 -> Insert after value X");
    //    Console.WriteLine("5 -> Delete from start, 6 -> Delete from end, 7 -> Delete from Kth position, 8 -> Delete after value X, 9 -> exit");
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
    //                int len = obj1.LengthOfLL(head);
    //                obj.InsertAtKthPosition(val3, k, len, ref head, ref tail);
    //                break;

    //            case "4":
    //                Console.Write("Enter value to insert: ");
    //                int val4 = int.Parse(Console.ReadLine());
    //                Console.Write("Enter existing value X after which to insert: ");
    //                int x1 = int.Parse(Console.ReadLine());
    //                obj.InsertAfterX(val4, x1, ref head, ref tail);
    //                break;

    //            case "5":
    //                obj.DeleteAtStart(ref head);
    //                break;

    //            case "6":
    //                obj.DeleteAtEnd(ref head, ref tail);
    //                break;

    //            case "7":
    //                Console.Write("Enter position (k) to delete: ");
    //                int k2 = int.Parse(Console.ReadLine());
    //                int len2 = obj1.LengthOfLL(head);
    //                obj.DeleteAtKthPosition(len2, k2, ref head, ref tail);
    //                break;

    //            case "8":
    //                Console.Write("Enter value X after which to delete: ");
    //                int x2 = int.Parse(Console.ReadLine());
    //                obj.DeleteAfterX(x2, ref head, ref tail);
    //                break;

    //            case "9":
    //                Console.WriteLine("Exiting...");
    //                return;

    //            default:
    //                Console.WriteLine("Invalid input. Please try again.");
    //                break;
    //        }

    //        Console.WriteLine("Current Linked List:");
    //        obj1.TraverseLL(head);
    //    }
    //}
}