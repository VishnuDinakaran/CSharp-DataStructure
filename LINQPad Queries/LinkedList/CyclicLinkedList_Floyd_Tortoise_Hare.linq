<Query Kind="Program" />

void Main()
{
	LL root = new LL(0);
	LL l1 = new LL(1); root.Next = l1;
	LL l2 = new LL(2); l1.Next = l2;
	LL l3 = new LL(3); l2.Next = l3;
	LL l4 = new LL(4); l3.Next = l4;
	LL l5 = new LL(5); l4.Next = l5;
	LL l6 = new LL(6); l5.Next = l6;
	//cycle
	l6.Next = l2;
	
	LL h = root;
	LL t = root;	
	while(h != null && h.Next != null)
	{
		h = h.Next.Next;
		t = t.Next;
		if(h == t) // if both pointers are same then its cyclic LinkeList
		{
			Console.WriteLine($"Cyclic Linked list identified --> pointer met at Hare={h} ; Tortoise={t}");			
			//move one pointer to start of the linked list and move both pointer one at a time , next time they meet will be the point of intersection 
			h = root;
			while(h != t)
			{
				h = h.Next;
				t = t.Next;				
			}
			Console.WriteLine($"Hare={h} ; Tortoise={t}");
			break;
		}
	}
}

// You can define other methods, fields, classes and namespaces here
public class LL
{
	public int Value {get; set;}
	public LL Next {get; set;}
	
	public LL(int val)
	{
		Value = val;
	}
	
	public override string ToString()
	{
		return $"val={Value} ";
	}
}