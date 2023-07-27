namespace Data_Structures;

public class Queue <T> where T : class
{
    public int Length { get; private set; }
    private  QNode<T>? _head;
    private QNode<T>? _tail;
    public Queue()
    {
        _head = _tail = null;
        Length = 0;
    }

   public void Enqueue(T item)
    {
        var node = new QNode<T>(item);
        Length++;
        if (_tail == null)
        {
            _tail = _head = node;
        }
        _tail.Next = node;
        _tail = node;
    }
   public T? Deque()
    {
        if (_head == null)
            return null;
        Length--;

       var head = _head;
       _head = _head.Next;

       head.Next = null;
       
       return _head?.Value;
    }
   public T? Peek() => _head?.Value;

}



public class QNode<TV>
{
    public QNode(TV item)
    {
        Value = item;
    }
    public TV Value { get; set; }
    public QNode<TV>? Next { get; set; }
    
}