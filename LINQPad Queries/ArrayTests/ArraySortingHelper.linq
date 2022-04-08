<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Quick Sort");
	//int[] arr =new int[] {80,23,1,2,55,77,65,43,6,11,31,45,89,90, 1, 6, 90};
	int[] arr = new int[] { 12, 3, 6, 23, 4, 6, 20, 22, 11, 7, 8, 9 };
	Console.WriteLine($"input array for quick sort : [{string.Join(", ", arr)}]");
	Console.WriteLine($"Sorted Array using quicksort => { string.Join(", ", ArraySortingHelper.QuickSort(arr))}");
}


public static class ArraySortingHelper
{
#region Dived & Concure

	#region Quick Sort // sort in same array
	//Time Complexity => /Best case  O(n log n) - Worst case : O(n2)
	//Best case : Time Complexity O(n log n) if the pivot is middle on the array - which is very unlikely and cannot be detected by program 
	// if we recursively divide the sub-array by two - 
	//Worst case : O(n2) if the list is already sorted - if pivote is first or last element => to avoid this select middle element to make it best case 
	// Algoritham 
	//  find mid point(pivotal) and swap all small element than pivot towards left and greater element towards right
	
	public static int[] QuickSort(int[] nums)
	{
		Console.WriteLine($"Length : {nums.Length}");
		QuickSort(nums, 0, nums.Length - 1);
		return nums;
	}
	private static void QuickSort(int[] nums, int l, int r)
	{
		if(r > l)
		{
		// Step 1. Find mid/pivot swap & make array with all elements smaller at left of pivot/mid and all elements right at right
		// get p => index of mid/pivot
			int  p = QuickSortPartision(nums, l, r); 
		// do same step1 for left sub array of mid/pivot
			QuickSort(nums, l, p-1);
		// do same step1 for Right sub array of mid/pivot
			QuickSort(nums, p+1, r);
		}
	}
	private static int QuickSortPartision(int[] nums, int l, int r)
	{
		int pivot = nums[l], i = l, pIdx = l;
		Console.WriteLine($" l:{l} ; r:{r} ; pivot:{pivot}");
		while (r > l)
		{
			while (r >= l && nums[l] <= pivot)
			{
				l++;
			}

			while (r >= l && nums[r] > pivot)
			{
				r--;
			}
			if(r > l)
			{
				//swap
				int temp = nums[l];
				nums[l] = nums[r];
				nums[r] = temp;
			}
		}
		
		int t = nums[i];
		nums[i] = nums[r];
		nums[r] = t;		
		pIdx = r;
		
		return pIdx;
	}
	#endregion


	#region BinarySearchSort // Create new array and insert in sorted array 
	
	public static int[] BinarySearchSort(int[] nums)
	{
		int[] result = new int[nums.Length];
		for(int i = 0; i < nums.Length; i++)   // O(n)
		{
			BinarySearchSort(result, nums[i], 0, nums.Length-1);
		}
		return result;
	}
	
	//private static int bArrSize = 0;
	public static void BinarySearchSort(int[] nums, int val, int l, int r)
	{
		if(r >= l)
		{
			int mid = l + (r-l) / 2;
			if(nums[mid] == val)
			{
				// found same item; need to insert next to it
			}
			else if (val < nums[mid])
			{
			}
			else
			{
			}
		}
		else
		{
		}
	}
	
	#endregion
	

	
	#region MergeSort
	public static void Merge(int[] nums)
	{
	}
	#endregion
#endregion
	
}