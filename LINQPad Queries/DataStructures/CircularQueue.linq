<Query Kind="Program" />

void Main()
{
	CircularQueue<int> q1 = new CircularQueue<int>(2);
	q1.Print();
	Console.WriteLine($"EnQ : {q1.EnQueue(4)}");
	Console.WriteLine($"GetRear : {q1.Rear()}");
	Console.WriteLine($"EnQ : {q1.EnQueue(9)}");
	q1.Print();
	Console.WriteLine($"DenQ : {q1.DeQueue()}");	
	Console.WriteLine($"GetFront : {q1.Front()}");
	q1.Print();
	Console.WriteLine($"DenQ : {q1.DeQueue()}");
	q1.Print();
	Console.WriteLine($"DenQ : {q1.DeQueue()}");	

	Console.WriteLine($"  ");
	Console.WriteLine($"***** END Q1  ******");

	int[] ar = new int[3] {1,2,3};
	CircularQueue<int> q = new CircularQueue<int>(3);
	q.Print();
	for(int i = 0 ; i<ar.Length; i++)
	{
		Console.WriteLine($"EnQ : {q.EnQueue(ar[i])}");
	}
	q.Print();
	Console.WriteLine($"EnQ : {q.EnQueue(4)}");	
	Console.WriteLine($"DenQ : {q.DeQueue()}");	
	Console.WriteLine($"EnQ : {q.EnQueue(5)}");
	Console.WriteLine($"GetRear : {q.Rear()}");
	Console.WriteLine($"GetFront : {q.Front()}");	
	Console.WriteLine($"IsFull : {q.IsFull()}");	
	q.Print();
	Console.WriteLine($"START : Entering While !IsEmpty");
	while(!q.IsEmpty())
	{		
		Console.WriteLine($"DenQ : {q.DeQueue()} ; IsFull : {q.IsFull()} ; IsEmpty : {q.IsEmpty()}");	
		q.Print();
	}
	Console.WriteLine($"END : Entering While !IsEmpty");
	q.Print();
}

public class CircularQueue<T> where T : new()
{
	T[] arr = null;
	private readonly int c ;
	private int nextInsertIndex = -1;
	private int nextEnqueueIndex = -1;
	private bool isQFullInMiddle = false;
	public CircularQueue(int capacity)
	{
		if (capacity < 0 ) throw new ArgumentException("invalid capacity");
		c = capacity;
		arr = new T[c];
		nextInsertIndex++;
		nextEnqueueIndex++;
	}
	
	/** Insert an element into the circular queue. Return true if the operation is successful. */
    public bool EnQueue(T value) {
        if(nextInsertIndex == c)
		{
			if(nextEnqueueIndex == 0)
			{
				return false;
			}
			else 
			{ 
				nextInsertIndex = 0; 
				if (nextEnqueueIndex == c) nextEnqueueIndex = 0;
			}
		}
		else if (isQFullInMiddle) {	return false; }
		
		arr[nextInsertIndex] = value;
		nextInsertIndex++;
		if(nextInsertIndex == nextEnqueueIndex) 
			isQFullInMiddle = true;
		return true;		
    }
    
    /** Delete an element from the circular queue. Return true if the operation is successful. */
    public bool DeQueue() {
        if(IsEmpty()) { return false; }
		bool result = false;
		if(nextEnqueueIndex < c)
		{
			arr[nextEnqueueIndex] = default(T);
			nextEnqueueIndex++;
			result =  true;
			isQFullInMiddle = false;
		}
		else if(nextEnqueueIndex == c)
		{
			nextEnqueueIndex = 0;
		}
		//
		
		return result;
    }
    
    /** Get the front item from the queue. */
    public T Front() {
        if(IsEmpty()) { return default(T); }
		return arr[nextEnqueueIndex];
    }
    
    /** Get the last item from the queue. */
    public T Rear() {
         if(IsEmpty()) { return default(T); }
		 return arr[nextInsertIndex - 1];
    }
    
    /** Checks whether the circular queue is empty or not. */
    public bool IsEmpty() {
        return ((!isQFullInMiddle && nextInsertIndex == nextEnqueueIndex));
    }
    
    /** Checks whether the circular queue is full or not. */
    public bool IsFull() {
       return  (isQFullInMiddle || (nextInsertIndex == c && nextEnqueueIndex == 0));
    }
	
	public void Print()
	{
		Console.WriteLine($"START Q => Capacity : {c} ; nextInsertIndex : {nextInsertIndex} ; nextEnqueueIndex : {nextEnqueueIndex} ; isQFullInMiddle : {isQFullInMiddle} ; Items = > [");
		for(int i=0; i < arr.Length; i++)
		{
			Console.Write($"{arr[i]}, ");
		}
		Console.WriteLine($"] END");
	}
}

