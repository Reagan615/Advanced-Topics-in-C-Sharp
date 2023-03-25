LinkedList<int> list01 = new LinkedList<int>();
list01.Add(1);
list01.Add(2);
list01.Add(3);
list01.printList();


LinkedList<string> list02 = new LinkedList<string>();
list02.Add("AAAA");
list02.Add("BBBB");
list02.Add("CCCC");
list02.printList();

public class LinkedList<T>
{
    public Node<T> Head { get; set; }

    public LinkedList()
    {
        Head = null;
    }
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);
        if (Head == null)
        {
            Head = node;
            return;
        }

        Node<T> temp = Head;

        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = node;
    }

    public void printList()
    {
        Node<T> n = Head;
        while (n != null)
        {
            Console.Write(n.Data + " ");
            n = n.Next;
        }
    }


}

