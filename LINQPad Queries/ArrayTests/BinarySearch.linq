<Query Kind="Program" />

void Main()
{

	int[] nums = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
	int v = 16;
	Console.WriteLine($" Input: [{string.Join(", ", nums)}] ; Find : {v}");
	Console.WriteLine($" Output (Binary Search Find index of): {BinarySearchItrative(nums, v)}");

	int[] arr = new int[]{1,2,3,4,5,6};
	int val = 2;
	Console.WriteLine($" Binary Search Find index of Val:{val}: {BinarySearch(arr, val, 0, arr.Length - 1)}");
}

// Binary Search Recursive 
public static int BinarySearch(int[] arr, int val, int l, int r)
{	
    if (r >= l) 
	{
		int m =  l + (r - l) / 2;
		//Console.WriteLine($"Left :{l} ; Mid: {m} ; Right:{r}");
		if(arr[m] == val)
		{
			  //Console.WriteLine($" Found Result: {val}");
			  return m; //arr[m];
		}
		if(val < arr[m])
		{
		    //Console.WriteLine($" - val less than mid : {val} < {arr[m]}");
			return BinarySearch(arr, val, l, m - 1);
		}
		else
		{
		    //Console.WriteLine($" - val greater than mid : {val} > {arr[m]}");
			return BinarySearch(arr, val, m + 1, r);
		}
	}
	else
	{
		//Console.WriteLine($"Out Of Range : l:{l} - r:{r}");
	}
	return -1; //not found
}

// Binary Search Iterative
public static int BinarySearchItrative(int[] nums, int v)
{
	int idx = -1;
	int l = 0,  r = nums.Length-1;
	
	while(r >= l)
	{
		int mid = l + (r-l)/2;
		if(nums[mid] == v)
		{	
			return mid; // insertion point of 'v' will be next to mid (mid+1)
			
		}
		else if (v < nums[mid])
		{
			r = mid-1;
		}
		else // v > nums[mid]
		{
			l = mid+1;
		}
	}	
	// if r > l; then  insertion point of 'v' will be next to r (r+1)
	return idx;
}