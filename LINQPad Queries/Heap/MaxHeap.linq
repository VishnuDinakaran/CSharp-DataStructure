<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Test Max Heap");
	MaxHeap max = new MaxHeap(9);
	max.Insert(50);	
	max.Print();
	max.Insert(30);
	max.Insert(15);
	max.Insert(10);
	max.Insert(8);
	max.Insert(16);
	max.Print();
	max.Insert(20);
	max.Print();
	max.Insert(60);
	max.Insert(70);
	max.Print();
	
	//max.Delete();
	max.Print();
	
	max.SortedArrayFromHeap();
	
}
// Heap is a complete binary tree 
// maintain complete binary is thumb rule for Heap
// Heap is always a complete binary tree , i.e, left, root & right in each level of the tree
// Heap Sort - create a heap and delete all elements one by one and stack the deleted items which will form sorted array

// 0,1,2,3,4,5,6,7,8
// if i is the index of the item in array
// Left Node => 2*i+1 is left node of i
// Right Node => 2*i+2 is right node of i
// Parent Node => (i-1)/2 is the parent of an item in index i

// INSERT Time Complexity- min O(n) to O(logn)
// Insert into heap should always be to its last index of the array - to make a complete tree & swap-up tree to the parent

// DELETE Time Complexity O(logn) 
// delete the top/root node (first index of array) & move last item in array to root 
// compare child elements of current root (after delete) and then swap root to (largest/smallest) child down 
// Delete is like Pop; arrange the deleted item one after other will get sorted array

// Heap is best data data struture for maintaing a Priority queue , since insertion and deletion takes O(log n)
public class MaxHeap
{
	private int?[] arr;
	private int size = -1;
	
	public MaxHeap(int capacity)
	{
		arr = new int?[capacity];
		size++;
	}
	
	public int ParentNodeIndex(int childIndex) =>  (childIndex - 1)/2;	
	public int LeftNodeIndex(int parentIndex) => 2*parentIndex + 1;	
	public int RightNodeIndex(int parentIndex) => 2*parentIndex + 2;
	
	public int Count { get { return size+ 1;} }
	public void Print()
	{
		Console.WriteLine($"MaxHeap : {String.Join(", ", arr)}");
	}
	
	
	public void Insert(int item)
	{
		if(size > arr.Length - 1) throw new IndexOutOfRangeException(" Heap is full");
		arr[size] = item;
		//SwapUp
		SwapUp(size);		
		size++;
	}
	public int Delete()
	{
		if(size < 0) throw new IndexOutOfRangeException("Heap is empty");
		int top = arr[0].Value;
		arr[0] = arr[size - 1];
		arr[size - 1] = null;
		// compare childs and swap down
		SwapDown();
		size--;
		return top;
	}
	public void SwapUp(int cI)
	{
		//SwapUp
		int pI = ParentNodeIndex(cI);
		while(arr[cI] > arr[pI] && cI != pI)
		{
			//SwapUp(i, pI);
			int temp = arr[cI].Value;
			arr[cI] = arr[pI];
			arr[pI] = temp;
			cI = pI;
			pI = ParentNodeIndex(cI);
		}
	}
	public void SwapDown()
	{
		int pI = 0;
		int lftVal = LeftNodeIndex(pI) < (size ) && arr[LeftNodeIndex(pI)].HasValue ? arr[LeftNodeIndex(pI)].Value : 0;
		int rightVal =  RightNodeIndex(pI) < (size) && arr[RightNodeIndex(pI)].HasValue ? arr[RightNodeIndex(pI)].Value : 0;
		int maxChildVal = Math.Max(lftVal, rightVal);
		int cI = lftVal > rightVal ? LeftNodeIndex(pI) : RightNodeIndex(pI);
		while(arr[pI] < maxChildVal && cI != pI && cI < size && pI < size )
		{
			int temp = arr[cI].Value;
			arr[cI] = arr[pI];
			arr[pI] = temp;
			
			pI = cI;
			lftVal = LeftNodeIndex(pI) < (size ) && arr[LeftNodeIndex(pI)].HasValue ? arr[LeftNodeIndex(pI)].Value : 0;
			rightVal =  RightNodeIndex(pI) < (size) && arr[RightNodeIndex(pI)].HasValue ? arr[RightNodeIndex(pI)].Value : 0;
			maxChildVal = Math.Max(lftVal, rightVal);
			cI = lftVal > rightVal ? LeftNodeIndex(pI) : RightNodeIndex(pI);
		}
	}
	
	public void SortedArrayFromHeap()
	{
		Console.WriteLine("Sort Begin");
		for	(int i = 0 ; i < Count; i++)
		{
			arr[arr.Length - (i+1)] = Delete();			
		}
		Print();
		Console.WriteLine("Sort END");
	}
}