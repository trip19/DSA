using System.Xml.Linq;

class CircularLinkedList
{
    public int LengthOfLL(Node head)
    {
        Node pointer = head;
        if(head == null)
        {
            return 0;
        }
        int count = 0;
        while (true)
        {
            count++;
            pointer = pointer.next;
            if (pointer == head)
            {
                break;
            }
        }
        return count;
    }
    public void TraverseLL(Node head)
    {
        Node pointer = head;
        while (true)
        {
            Console.Write(pointer.data + " -> ");
            pointer = pointer.next;
            if(pointer == head)
            {
                break;
            }
        }
        Console.WriteLine("");
    }
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
        tail.next = head;
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
        tail.next = head;
    }
    public void InsertAtKthPosition(int val, int k, int len, ref Node head, ref Node tail)
    {
        Node node = new Node(val);
        if (len == 0)
        {
            if (k == 1)
            {
                head = node;
                tail = node;
                tail.next = head;
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
                tail.next = head;
            }
            else if (k == len + 1)
            {
                tail.next = node;
                tail = node;
                tail.next = head;
            }
            else if (k > len + 1)
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
                node.next = pos.next;
                pos.next = node;
            }
        }
    }
    public void DeleteAtStart(ref Node head, ref Node tail)
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
            head = head.next;
            tail.next = head;
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
            tail.next = head;
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
                    tail.next = head;
                }
                else if (k == len)
                {
                    Node pointer = head;
                    while (pointer.next != tail)
                    {
                        pointer = pointer.next;
                    }
                    tail = pointer;
                    tail.next = head;
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

    public static void Main(string[] args)
    {
        Node head = null;
        Node tail = null;
        CircularLinkedList obj = new CircularLinkedList();
        Console.WriteLine("Operations in a LinkedList: ");
        Console.WriteLine("1 -> Insert at start, 2 -> Insert at end, 3 -> Insert at Kth position,");
        Console.WriteLine("4 -> Delete from start, 5 -> Delete from end, 6 -> Delete from Kth position, 7 -> exit");
        while (true)
        {
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter value to insert at start: ");
                    int val1 = int.Parse(Console.ReadLine());
                    obj.InsertAtStart(val1, ref head, ref tail);
                    break;

                case "2":
                    Console.Write("Enter value to insert at end: ");
                    int val2 = int.Parse(Console.ReadLine());
                    obj.InsertAtEnd(val2, ref head, ref tail);
                    break;

                case "3":
                    Console.Write("Enter value to insert: ");
                    int val3 = int.Parse(Console.ReadLine());
                    Console.Write("Enter position (k): ");
                    int k = int.Parse(Console.ReadLine());
                    int len = obj.LengthOfLL(head);
                    obj.InsertAtKthPosition(val3, k, len, ref head, ref tail);
                    break;

                case "4":
                    obj.DeleteAtStart(ref head, ref tail);
                    break;

                case "5":
                    obj.DeleteAtEnd(ref head, ref tail);
                    break;

                case "6":
                    Console.Write("Enter position (k) to delete: ");
                    int k2 = int.Parse(Console.ReadLine());
                    int len2 = obj.LengthOfLL(head);
                    obj.DeleteAtKthPosition(len2, k2, ref head, ref tail);
                    break;

                case "7":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }

            if (head == null)
            {
                Console.WriteLine("No value to show");
            }
            else
            {
                Console.WriteLine("Current Linked List:");
                obj.TraverseLL(head);
            }
        }
    }
}