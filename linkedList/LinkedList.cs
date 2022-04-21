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

        private Node? next;
        public Node Next 
        {
            get { return next; }
            set { next = value; }
        }
    
    }

    private Node? _head;
    private Node? _current;
    private Node? _prev;

    public LinkedList()
    {
        _head = null;
    }

    /// <summary>
    ///  Will add element in the last position
    /// </summary>
    /// <param name="item">Generic</param>
    public void Add(T item)
    {
        _current = _head;   
        if(_head == null)
        {
            Node val = new Node(item);
            _head = val;
            return;
        } 

        while(true)
        {
            if (_current.Next == null)
            {
                Node val = new Node(item);
                _current.Next = val;
                return;
            }
            
            _current = _current.Next;
        } 
    }

    /// <summary>
    ///  Will remove the element by index
    /// </summary>
    /// <param name="index">int</param>
    public void Remove(int index = 0)
    {
        int aux = 0;

        if (_head == null)
        {
            Console.Write("Lista vazia");
            return;
        }

        _current = _head;
        _prev = null;
        
        if(index == 0)
        {
            _head = _current.Next;
            return;
        }

        while(_current != null)
        {
            if (aux == index)
            {
                _prev.Next = _current.Next;
                return;
            } 
            
            if (aux < index && _current.Next == null)
            {
                Console.WriteLine("Não foi possível remover este elemento");
                return;
            }

            _prev = _current;
            _current = _current.Next;
            aux++;
        }
    }

    public void Print()
    {
        _current = _head;
        while(_current != null)
        {
            Console.WriteLine(_current.Val);
            _current = _current.Next;
        }
    }
}