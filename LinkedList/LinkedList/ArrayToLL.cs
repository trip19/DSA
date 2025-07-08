class Node
{
    public int data;
    public Node next;

    public Node() { }
    public Node(int data1)
    {
        data = data1;
        next = null;
    }

    public Node(int data1, Node next1)
    {
        data = data1;
        next = next1;
    }
}
class ArrayToLL
{
    public Node ConvertArrToLL(int[] arr)
    {
        Node head = new Node(arr[0]);
        Node i = head;
        for(int c = 1; c < arr.Length; c++)
        {
            Node j = new Node(arr[c]);
            i.next = j;
            i = j;
        }
        return head;
    }
    public void TraverseLL(Node head)
    {
        Node pointer = head;
        while (pointer != null)
        {
            Console.Write(pointer.data + " -> ");
            pointer = pointer.next;
        }
        Console.WriteLine("");
    }
    public void ReverseLL(ref Node head)
    {
        Node prev = head;
        Node curr = head.next;
        Node temp;
        while (curr != null)
        {
            if (prev == head)
            {
                prev.next = null;
            }
            temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        head = prev;
        Console.WriteLine("The LinkedList has been reversed: ");
    }
    public int LengthOfLL(Node head)
    {
        Node pointer = head;
        int count = 0;
        while (pointer != null)
        {
            count++;
            pointer = pointer.next;
        }
        return count;
    }
    public bool SearchLL(Node head, int key)
    {
        Node pointer = head;
        while (pointer != null)
        {
            if(pointer.data == key)
            {
                return true;
            }
            pointer = pointer.next;
        }
        return false;
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 64, 25, 12, 22, 11 };
    //    ArrayToLL obj = new ArrayToLL();
    //    Node head = obj.ConvertArrToLL(arr);
    //    Console.WriteLine("The LinkedList is as follows: ");
    //    obj.TraverseLL(head);
    //    obj.ReverseLL(ref head);
    //    obj.TraverseLL(head);
    //    Console.WriteLine("The length of the LinkedList is: " + obj.LengthOfLL(head));
    //    if (obj.SearchLL(head, 25))
    //    {
    //        Console.WriteLine("The element is found in the LinkedList");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The element is not found in the LinkedList");
    //    }
    //}
}

