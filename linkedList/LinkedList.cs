public class LinkedList<T>
{
    private class Node 
    {
        public Node(T t)
        {
            Next = null;
            val = t;
        }
        private T val;
        public T Val 
        {
            get { return val; }
            set { val = value; }
        }

        private Node next;
        public Node Next 
        {
            get { return next; }
            set { next = value; }
        }
    
    }

    private Node head;
    private Node current;

    public LinkedList()
    {
        head = null;
    }

    public void Add(T item)
    {
        current = head;   
        if(head == null)
        {
            Node val = new Node(item);
            head = val;
            return;
        } 

        while(true)
        {
            if (current.Next == null)
            {
                Node val = new Node(item);
                current.Next = val;
                return;
            }
            
            current = current.Next;
        } 
    }

    public void Remove(int index = 0) 
    {
        int aux = 0;
        current = head;

        if(index == 0)
        {
            current = head.Next;
            return;
        }

        while(true)
        {
            if(current.Next == null && aux <= index - 1)
            {
                Console.WriteLine("Não foi possivel deletar, pois não foi encontrado o elemento");
                return;
            }

            if(index == aux)
            {
                if(current.Next == null)
                {
                    return;
                }

                current = current.Next;
                current.Next = null;
            }
            
            current = current.Next;
            aux++;
        }
    }

    public void Print()
    {
        current = head;
        while(current != null)
        {
            Console.WriteLine(current.Val);
            current = current.Next;
        }
    }

    public void linkedPrint()
    {
     
    }

}