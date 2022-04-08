<Query Kind="Program" />

void Main()
{
	//int[] nums = new int[] { 12, 3, 6, 23, 4, 6, 20, 22, 11, 7, 8, 9, 6, 23 };
	//int[] nums =new int[] {80,23,1,2,55,77,65,43,6,11,31,45,89,90, 1};
	//int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 ,13 };
	//int[] nums = new int[] { 13, 12, 11, 10, 9, 8, 7,  6, 5, 4, 3, 2 ,1 };
	
	//int[] nums = new int[] { 9, 1, 10, 2, 8, 5, 4 ,6 ,3, 7};
	//int[] nums = new int[] { 5, 10, 2, 1, 4, 6, 3 , 6};
	
	int[] nums =new int[] { 12, 3,6,23,4,6,20,22,11 };
	
	Console.WriteLine($" QuickSort Input Array : [{string.Join(", ", nums)}] ");
	MergeSort(nums);
	Console.WriteLine($" QuickSort Output : [{string.Join(", ", nums)}] ");
}

public static void MergeSort(int[] nums)
{
	MergeSort(nums, 0, nums.Length-1);
}

private static void MergeSort(int[] nums, int l, int r)
{
	if(r > l)
	{
		int mid = l + (r-l)/2;
		MergeSort(nums, l, mid);
		MergeSort(nums, mid+1, r);
		Console.WriteLine($" ");
		Console.WriteLine($" l: {l} ; mid : {mid} ; r: {r}");
		Console.Write($" => Berfor Merge : ");
		for(int i = 0; i <= r; i++)
		{
			Console.Write($"{nums[i]}, ");
		}
		Console.WriteLine($" ");
		Merge(nums, l , mid, r);
		Console.Write($" => After Merge : ");
		for(int i = 0; i <= r; i++)
		{
			Console.Write($"{nums[i]}, ");
		}
	}	
}

private static void Merge(int[] nums, int l, int mid, int r)
{
	//int m = mid+1, i = l;
	//if(r > l)
	//{
	//	while(i < r )
	//	{
	//		if(nums[m] < nums[i])
	//		{
	//			int t = nums[m];
	//			nums[m] = nums[i];
	//			nums[i] = t;
	//		}
	//		i++;
	//	}
	//}
}