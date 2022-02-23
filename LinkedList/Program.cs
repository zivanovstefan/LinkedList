using LinkedList;

var linkedStack = new LinkedStack<int>();
linkedStack.AddNode(1);
linkedStack.AddNode(2);
linkedStack.AddNode(3);
linkedStack.AddNode(4);
linkedStack.AddNode(5);

Console.WriteLine($"Display last added value : {linkedStack.Peek()}");
linkedStack.Print();