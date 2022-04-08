<Query Kind="Program" />

void Main()
{
	Node root = new Node(20);
	root.Insert(9);
	root.Insert(25);
	root.Insert(5);
	root.Insert(12);
	root.Insert(11);
	root.Insert(14);
	
	//Breath-First-Search
	Console.WriteLine($" BFS ");
	Queue<Node> q = new Queue<Node>();
	q.Enqueue(root);
	while(q.Count > 0)
	{
		Node n = q.Dequeue();
		Console.WriteLine($"{n.Value}");
		if(n.Left != null)
			q.Enqueue(n.Left);
		if(n.Right != null)
			q.Enqueue(n.Right);
	}
	
	//Depth-First-Search
	Console.WriteLine($"  ");
	Console.WriteLine($" DFS ");
	Stack<Node> s = new Stack<Node>();
	s.Push(root);
	while(s.Count > 0)
	{
		Node sn = s.Pop();
		Console.WriteLine($"{sn.Value}");		
		if(sn.Right != null)
			s.Push(sn.Right);
		if(sn.Left != null)
			s.Push(sn.Left);
	}
	
	public Node FindInOrderSuccessor(Node n)
	{
		if(n == null)
			return null;
		
		long val = n.Value;
		if(n.Value >
		
		return null;
	}
}

public class Node
{
	public Node Left { get; set; }
	public Node Right { get; set; }
	public Node Parent { get; set; }

	public long Value { get; set; }
	
	public Node(long v)
	{
	   Value = v;
	}
	
	public void Insert(long v)
	{		
		if(v < Value)
		{
			if(Left == null)	
			{
				Left = new Node(v);
				Left.Parent = this;
			}
			else
			{
				Left.Insert(v);
			}
		}
		else
		{
			if(Right == null)	
			{
				Right = new Node(v);
				Right.Parent = this;
			}
			else
			{
				Right.Insert(v);
			}
		}
	}
}

// You can define other methods, fields, classes and namespaces here
