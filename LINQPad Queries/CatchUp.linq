<Query Kind="Program" />

void Main()
{
	//int[] arr = new int[]{4,3,6,7,8,9,1,11,9,2,0,5,10,0,0,0,0,11,11,12,3};
	int[] arr = new int[]{29,2,4,7,4};
	Console.WriteLine($"Before QuickSort : {string.Join(",", arr)}");
	QuickSort(arr);
	Console.WriteLine($"After QuickSort : {string.Join(",", arr)}");
	Console.WriteLine(" ");
	
	int bSerVal = 7;
	Console.WriteLine($"BinarySearch : {BinarySearch(arr, 0, arr.Length-1, bSerVal)}");	
	Console.WriteLine(" ");
	
	List<int> binSerInsertArr = arr.ToList();
	int insert = 0;
	Console.WriteLine($"BinarySearchInsert Before : {string.Join(",", binSerInsertArr)}  |  Insert : {insert}");
	BinarySearchInsert(binSerInsertArr, 0, binSerInsertArr.Count-1, insert);
	Console.WriteLine($"BinarySearchInsert After : {string.Join(",", binSerInsertArr)}");
	Console.WriteLine(" ");
	
	Console.WriteLine($"Happy I'm BACK!!!!");
}

//Inline Sort on STATIC ARRAY
public void QuickSort(int[] arr)
{
	QuickSort(arr, 0, arr.Length-1);
}

private static void QuickSort(int[] arr, int l, int r)
{
	if(r > l)
	{		
		int pIdx = l;
		int p = arr[pIdx];
		l++;
		while (r >= l)
		{
			while(r >= l && arr[l] < p)
			{
				l++;
			}					
			while(r >= l && arr[r] > p)
			{
				r--;				
			}		
			if(r >= l)
			{
				int tmp = arr[l];
				arr[l] = arr[r];
				arr[r] = tmp;
				r--; l++;
			}
		}			
		int tmp1 = arr[r];
		arr[r] = arr[pIdx];
		arr[pIdx] = tmp1;
		
		QuickSort(arr, pIdx, r);
		QuickSort(arr, r+1, arr.Length-1);
	}
}

public int BinarySearch(int[] arr, int l, int r, int val)
{
	if(r >= l)
	{
		int mid = l + (r-l)/2;
		if(arr[mid] == val)
		{
			return mid;
		}
		else if(arr[mid] > val)
		{
			return BinarySearch(arr, l, mid-1, val);
		}
		else // if (arr[mid] < val)
		{
			return BinarySearch(arr, mid+1, r, val);
		}
	}		
	return -1;
}

//inline insert on List (NOT on Static ARRAY)
public void BinarySearchInsert(List<int> arr, int l, int r, int val)
{
	if(r >= l)
	{
		int mid = l + (r-l)/2;
		if (arr[mid] == val)
		{
			arr.Insert(mid+1, val);
		}
		else if (arr[mid] > val)
		{
			BinarySearchInsert(arr, l, mid-1, val);
		}
		else // if (arr[mid] < val)
		{
			BinarySearchInsert(arr, mid+1, r, val);
		}		
	}
	else
	{
		// 0,1,2,3
		arr.Insert(r+1, val);
	}
}

public class LLtNode
{
	public int Value { get; set; }
	public LLtNode Next { get; set; }
}

// Sort Linked List
// find item in LL in Time Complexity 

public void LinkeList()
{
	LLtNode node4 = new LLtNode(){ Value = 4 , Next = null };
	LLtNode node3 = new LLtNode(){ Value = 3 , Next = node4 };
	LLtNode node2 = new LLtNode(){ Value = 2 , Next = node3 };
	LLtNode node1 = new LLtNode(){ Value = 1 , Next = node2 };
	
	
}


