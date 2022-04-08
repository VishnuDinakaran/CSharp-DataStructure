<Query Kind="Program" />

void Main()
{
	MinHeap min = new MinHeap(9);
	min.Insert(20);
	min.Insert(30);
	min.Insert(40);
	min.Print();
	min.Insert(15);
	min.Print();
	min.Insert(10);
	min.Insert(50);
	min.Insert(5);
	min.Print();
	min.Insert(100);
	min.Insert(1);
	min.Print();
	
	min.SortMinHeapArray();
}

// Define other methods, classes and namespaces here
public class MinHeap
{
	private int?[] arr;
	private int size = -1;
	
	public MinHeap(int capacity)
	{
		arr = new int?[capacity];
		size++;
	}
	
	private int ParentNodeIndex(int childIndex) => (childIndex-1) / 2;
	private int LeftNodeIndex(int parentIndex) => (2 * parentIndex)+1 / 2;
	private int RightNodeIndex(int parentIndex) => (2 * parentIndex)+2 / 2;

	public int Count { get{ return size + 1; } }
	
	public void Print()
	{
		Console.WriteLine(string.Join(", ", arr));
	}
	
	public void Insert(int value)
	{
		if(size >= arr.Length) throw new IndexOutOfRangeException("Heap is full");
		arr[size] = value;
		//SwapUp
		SwapUp(size);
		size++;
	}
	private void SwapUp(int cI)
	{
		int pI = ParentNodeIndex(cI);
		while(cI != pI && arr[pI] > arr[cI])
		{
			int temp = arr[cI].Value;
			arr[cI] = arr[pI];
			arr[pI] = temp;
			cI = pI;
			pI = ParentNodeIndex(cI);
		}
	}
	
	public int Delete()
	{
		if(size < 0) throw new IndexOutOfRangeException("Heap is empty");
		int result = arr[0].Value;
		arr[0] = arr[size - 1];
		arr[size - 1] = null;
		size--;
		//swapDown
		SwapDown();		
		return result;
	}
	
	private void SwapDown()
	{
		int pI = 0;
		int lVal = LeftNodeIndex(pI) < size && arr[LeftNodeIndex(pI)].HasValue ? arr[LeftNodeIndex(pI)].Value : 0;
		int rVal = RightNodeIndex(pI) < size && arr[RightNodeIndex(pI)].HasValue ? arr[RightNodeIndex(pI)].Value : 0;
		int minVal = Math.Min(lVal, rVal);
		int cI = lVal < rVal ? LeftNodeIndex(pI) : RightNodeIndex(pI);
		while(pI < size && cI < size && cI != pI && arr[pI] > minVal)
		{
			int temp = arr[pI].Value;
			arr[pI] = arr[cI].Value;
			arr[cI] = temp;
			
			pI = cI;
			lVal = LeftNodeIndex(pI) < size && arr[LeftNodeIndex(pI)].HasValue ? arr[LeftNodeIndex(pI)].Value : 0;
		    rVal = RightNodeIndex(pI) < size && arr[RightNodeIndex(pI)].HasValue ? arr[RightNodeIndex(pI)].Value : 0;
		    minVal = Math.Min(lVal, rVal);
		    cI = lVal < rVal ? LeftNodeIndex(pI) : RightNodeIndex(pI);			
		}		
	}
	
	public void SortMinHeapArray()
	{
		Console.WriteLine("Sorting Begin");
		for(int i = 0; i < Count; i++)
		{
			arr[arr.Length - (i+1)] = Delete();
		}
		Print();
		Console.WriteLine("Sorting END");
	}
}