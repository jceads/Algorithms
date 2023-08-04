// See https://aka.ms/new-console-template for more information

var que = new Data_Structures.Queue<Ammo>();
que.Enqueue(new(".45"));
que.Enqueue(new("9mm"));
que.Enqueue(new("31"));
que.Enqueue(new(".445"));
Console.WriteLine($"queue length {que.Length}");

que.Deque();
que.Deque();
que.Deque();
// que.Deque();
Console.WriteLine($"queue length {que.Length}");
Console.WriteLine($"{que.Peek()}");

var _stack = new Data_Structures.Stack<int>();
_stack.Push(5);
_stack.Push(10);
_stack.Push(15);
_stack.Push(20);
Console.WriteLine($"head item is {_stack.Peek()}");
Console.WriteLine($"popped item is {_stack.Pop()}");
Console.WriteLine($"head item is {_stack.Peek()}");
Console.WriteLine($"Length is {_stack.Length}");
Console.WriteLine($"popped item is {_stack.Pop()}");
Console.WriteLine($"popped item is {_stack.Pop()}");
Console.WriteLine($"popped item is {_stack.Pop()}");
Console.WriteLine($"popped item is {_stack.Pop()}");
