<Query Kind="Program" />

void Main()
{
	//int[] nums = new int[] { 12, 3, 6, 23, 4, 6, 20, 22, 11, 7, 8, 9, 6, 23 };
	int[] nums =new int[] {80,23,1,2,55,77,65,43,6,11,31,45,89,90, 1};
	//[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 ,13 };
	//int[] nums = new int[] { 13, 12, 11, 10, 9, 8, 7,  6, 5, 4, 3, 2 ,1 };
	
	//int[] nums = new int[] { 9, 1, 10, 2, 8, 5, 4 ,6 ,3, 7};
	//int[] nums = new int[] { 5, 10, 2, 1, 4, 6, 3 , 6};
	
	Console.WriteLine($" BubbleSort Input Array : [{string.Join(", ", nums)}] ");
	BubbleSort(nums);
	//Console.Write($" .; ");
	Console.WriteLine($" BubbleSort Output : [{string.Join(", ", nums)}] ");
}

/*
	Worst complexity	: n^2
	Average complexity	: n^2
	Best complexity		: n
	Space complexity	: 1
*/
private static void BubbleSort(int[] nums)
{
	int n = nums.Length , ct = 0;	
		Console.Write($"Array Length : {nums.Length} ");
		Console.WriteLine($"");
	bool swapped = false;
	while(n >= 0)								// O(n)
	{
		Console.Write($"{++ct}, ");
		for(int i = 1; i < n; i++)				// O(log n)
		{
			if(nums[i] < nums[i-1])
			{
				int t = nums[i];
				nums[i] = nums[i-1];
				nums[i-1] = t;
				swapped = true;
			}
			Console.WriteLine($" i:{i} : [{string.Join(", ", nums)}] ");
		}
		if(!swapped)
			break;								// Best Cast O(n)
		n--;
		Console.WriteLine($" -> n:{n} : [{string.Join(", ", nums)}] ");
		Console.WriteLine($" ");
	}
	Console.WriteLine($" ");
}
