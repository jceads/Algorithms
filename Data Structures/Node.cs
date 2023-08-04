namespace Data_Structures;

public class Node<T>
{
    public Node(T item)
    {
        Value = item;
    }
    public T Value { get; set; }
    public Node<T>? Next { get; set; }
    public Node<T> Previous { get; set; }
    
}