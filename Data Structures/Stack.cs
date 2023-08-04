using System.Xml;

namespace Data_Structures;

public class Stack <TV>
{
    private Node<TV>? Head { get; set; }
    public int Length { get; set; } = 0;

    public void Push(TV value)
    {
        Node<TV> node = new(value); 
        Length++;
        if (Head == null)
        {
            Head = node;
            return;
        }
        node.Previous = Head;
        Head = node;
    }
    public TV? Pop()
    {
        Length = Math.Max(0,Length - 1);
        if (Length == 0)
        {
            if (Head == null)
                return default;
            var _head = Head;
            Head = null;
            return _head.Value;
        }
        var head = Head;
        Head = head.Previous;
        return head.Value;

    }
    public TV? Peek() => Head != null ? Head.Value : default;
}