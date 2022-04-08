<Query Kind="Program" />

void Main()
{
	//int[] nums = new int[] { 12, 3, 6, 23, 4, 6, 20, 22, 11, 7, 8, 9, 6, 23 };
	int[] nums =new int[] {80,23,1,2,55,77,65,43,6,11,31,45,89,90, 1};
	//int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 ,13 };
	//int[] nums = new int[] { 13, 12, 11, 10, 9, 8, 7,  6, 5, 4, 3, 2 ,1 };
	
	//int[] nums = new int[] { 9, 1, 10, 2, 8, 5, 4 ,6 ,3, 7};
	//int[] nums = new int[] { 5, 10, 2, 1, 4, 6, 3 , 6};
	
	Console.WriteLine($" QuickSort Input Array : [{string.Join(", ", nums)}] ");
	QuickSort(nums, 0, nums.Length-1);
	Console.WriteLine($" QuickSort Output : [{string.Join(", ", nums)}] ");
}


private static int[] QuickSort(int[] nums)
{
	QuickSort(nums, 0, nums.Length-1);
	return nums;
}

private static void QuickSort(int[] nums, int l, int r)
{
	if(r > l)
	{
		int mid = PartisionRightAsPivot(nums, l, r); //PartisionLeftAsPivot(nums, l, r);
		QuickSort(nums, l, mid-1);
		QuickSort(nums, mid+1, r);
	}
}

private static int PartisionLeftAsPivot(int[] nums, int l, int r)
{
	int i = l, pIdx = l, pivot = nums[l];
	
	while(r > l)
	{
		while(r >= l && nums[l] <= pivot)
		{
			l++;
		}
		while(r >= l && nums[r] > pivot)
		{
			r--;
		}
		
		if(r > l)
		{
			int t = nums[l];
			nums[l] = nums[r];
			nums[r] = t;
		}		
	}
	int tmp = nums[i];
	nums[i] = nums[r];
	nums[r] = tmp;
	pIdx = r;
	
	return pIdx;
}

private static int PartisionRightAsPivot(int[] nums, int l, int r)
{
	int i = r, pIdx = r, pivot = nums[r];
	while(r > l)
	{
		while(r >= l && nums[r] >= pivot)
		{
			r--;
		}
		while(r >= l && nums[l] < pivot)
		{
			l++;
		}
		if(r > l)
		{
			int t = nums[r];
			nums[r] = nums[l];
			nums[l] = t;
		}
	}
	int tmp = nums[i];
	nums[i] = nums[l];
	nums[l] = tmp;
	pIdx = l;
	return pIdx;
}