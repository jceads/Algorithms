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