<Query Kind="Program" />

void Main()
{
	int[] ar = new int[3] {1,2,3};
	Deuque<int> d = new Deuque<int>(52);
	
	//d.InsertLast(1);
	//d.InsertLast(2);
	d.InsertFront(80);
	Console.WriteLine($"PeekDequeue : {d.PeekDequeue()}");
	d.InsertFront(27);
	Console.WriteLine($"PeekDequeue : {d.PeekDequeue()}");
	Console.WriteLine($"Pop : {d.Pop()}");
	d.InsertFront(60);
	d.InsertFront(81);
	Console.WriteLine($"{d.PeekPop()}");
	Console.WriteLine($"{d.PeekDequeue()}");
	Console.WriteLine($"{d.PeekPop()}");
	Console.WriteLine($"{d.PeekPop()}");
	d.InsertLast(46);
	
	
	//d.InsertFront(4);;
	//Console.WriteLine($"{d.PeekDequeue()}");
	d.Print();
}

public class Deuque<T> 
	where T : new()
{
	T[] arr = null;
	int c = -1;
	int nextInsertIndex = -1;
	int nextEnqueueIndex = -1;
	public Deuque(int capacity)
	{
		if(capacity < 0) throw new ArgumentException("Deque capacity is invalid");
		arr = new T[capacity];
		c = capacity;
		nextInsertIndex++;
		nextEnqueueIndex++;
	}
	
	private bool IsDeuqueFull;
	
	//Insert item to the queue
	public void InsertLast(T item)
	{
		if(nextInsertIndex >= c)
		{
			if(nextEnqueueIndex == 0)
			{
				Print();
				throw new IndexOutOfRangeException("Deque capacity is full");
			}
			else
			{
				nextInsertIndex = 0;
			}
		}
		else if (IsDeuqueFull)
		{
			Print();
			throw new IndexOutOfRangeException("Deque capacity is full");
		}
		arr[nextInsertIndex] = item;
		if(nextInsertIndex < nextEnqueueIndex && nextInsertIndex+1 == nextEnqueueIndex)
		{
			IsDeuqueFull = true;
		}
		else
		{
			IsDeuqueFull = false;
		}
		nextInsertIndex++;
	}
	
	public void InsertFront(T item)
	{
		if(IsDeuqueFull || (nextEnqueueIndex == 0 && nextInsertIndex >= c))
		{
			Print();
			throw new IndexOutOfRangeException("Deque capacity is full");
		}
		if(IsEmpty())
		{
			InsertLast(item);
			return;
		}
		else
		{
			if(nextEnqueueIndex-1 < 0 && nextInsertIndex < c)
			{
				nextEnqueueIndex = c-1;
				arr[nextEnqueueIndex] = item;
			}
			else if(nextEnqueueIndex-1 != nextInsertIndex || nextEnqueueIndex-1 != nextInsertIndex-1)
			{
				nextEnqueueIndex -= 1;
				arr[nextEnqueueIndex] = item;
			}
			if(nextInsertIndex == nextEnqueueIndex)
			{
				IsDeuqueFull = true;
			}
			else
			{
				IsDeuqueFull = false;
			}
		}
	}
	
	
	//Get last inserted item
	public T Pop()
	{
		if((!IsDeuqueFull && nextInsertIndex == nextEnqueueIndex)) 
		{		
			Print();
			throw new IndexOutOfRangeException("Deque is empty");
		}
		if(nextInsertIndex == 0 && nextEnqueueIndex > 0)
		{
			nextInsertIndex = c;
		}
		T result = arr[nextInsertIndex-1];
		arr[nextInsertIndex-1] = default(T);
		nextInsertIndex--;
		IsDeuqueFull = false;
		return result;
	}
	
	
	public T PeekPop()
	{
		if((!IsDeuqueFull && nextInsertIndex == nextEnqueueIndex))
		{
			Print();
			throw new IndexOutOfRangeException("Deque is empty"); 
		}
		if(nextInsertIndex == 0 && nextEnqueueIndex > 0)
		{
			nextInsertIndex = c;
		}
		T result = arr[nextInsertIndex-1];		
		return result;
	}
	
	public T Dequeue()
	{
		if(!IsDeuqueFull && nextInsertIndex == nextEnqueueIndex) 
		{
			Print();
			throw new IndexOutOfRangeException("Deque is empty"); 
		}
		T result = arr[nextEnqueueIndex];
		arr[nextEnqueueIndex] = default(T);
		nextEnqueueIndex = (nextEnqueueIndex+1 >= c && nextInsertIndex < c) ? 0 : nextEnqueueIndex + 1 ;
		IsDeuqueFull = false;
		return result;
	}
	
	public T PeekDequeue()
	{
		if((!IsDeuqueFull && nextInsertIndex == nextEnqueueIndex)) throw new IndexOutOfRangeException("Deque is empty"); 
		if(nextEnqueueIndex >= c)
		{
		   	nextEnqueueIndex = 0;
		}
		return arr[nextEnqueueIndex];
	}
	
	 /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty() {        
		return (!IsDeuqueFull && nextInsertIndex == nextEnqueueIndex);
    }
    
    /** Checks whether the circular deque is full or not. */
    public bool IsFull() {
        return (IsDeuqueFull || (nextInsertIndex >= c && nextEnqueueIndex == 0));
    }
		
	
	public void Print()
	{
		Console.WriteLine($" ");
		Console.Write($"STRAT => Print Deuque capacity : {c} ; IsDeuqueFull: {IsDeuqueFull}; nextInsertIndex : {nextInsertIndex} ; nextEnqueueIndex : {nextEnqueueIndex} ; Items => [");
		for(int i = 0; i < arr.Length; i++)
		{
			Console.Write($"{arr[i]}, ");
		}
		Console.WriteLine($"]  ");
		Console.WriteLine($"Print Deuque END");
	}
}

