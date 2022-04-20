public class LinkedList<T>
{
    public T Val { get; set; }
    public LinkedList<T> Next { get; set; }
    public LinkedList<T> Previous { get; set; }

    public void Add(T item)
    {
        if(this.Previous == null && this.Next == null)
        {
            this.Val = item;
            this.Previous = this;
            return;
        }

        if (this.Next == null)
        {
            this.Next = new LinkedList<T>();
            this.Next.Val = item;
            this.Next.Previous = this;
            return;
        }

        Next.Add(item);
    }

    public void Percorre()
    {
        Console.WriteLine(this.Val);
        
        if(this.Next == null)
        {
            return;
        }

        Next.Percorre();
    }

    public void listaLinkada()
    {
        if(this.Next == null)
        {
            Console.Write($"<= {this.Val}");
            return;
        }

        if(this.Previous.GetHashCode() == this.GetHashCode())
        {
            Console.Write($"{this.Val}");
        } else {
            Console.Write($" <= {this.Val} => ");
        } 
        
       this.Next.listaLinkada();

    }

}