<Query Kind="Program" />

void Main()
{
	int[] arr = new int[]{1,3,-1,-3,5,3,6,7};
	Console.WriteLine($"median Input Array  : [{string.Join(", ", arr )}]");
	double[] r = MedianSlidingWindow(arr, 3);
	Console.WriteLine($"median Result  	    	: [{string.Join(", ", r )}]");
	
}

  public double[] MedianSlidingWindow(int[] nums, int k) {
        if(nums.Length <= 0) return new double[0];
        if(nums.Length == 1) return new double[1]{nums[0]};
        
        double[] result = new double[(nums.Length-k)+1];      
        List<int> srtedlst = new List<int>(k);   
        bool isEven = (k % 2 == 0);
        int midIndex = k / 2;        
        int r = -1;
            
        //Created Sorted
        int j = k-1;        
        while(j >= 0)
        {
            BinarySortInsert(srtedlst, 0, srtedlst.Count - 1, nums[j--]);
        }
        PopulateMedian(srtedlst, ++r, result, isEven, midIndex);   
		//Sliding Window
        int itemToRemoveIndex = 0;
        for(j = k; j < nums.Length; j++, itemToRemoveIndex++)
        {
            BinarySortRemove(srtedlst, 0, srtedlst.Count - 1, nums[itemToRemoveIndex]); // O(log n)
            BinarySortInsert(srtedlst, 0, srtedlst.Count - 1, nums[j]);  // O(log n)
            PopulateMedian(srtedlst, ++r, result, isEven, midIndex);           
        }                       
        return result;
    }
    
   private static void PopulateMedian(List<int> lst, int r, double[] result, bool isEven, int midIndex)
   {
        if(isEven)
        {
           result[r] = ((double)lst[midIndex] + (double)lst[midIndex-1]) / (double)2;
        }
        else
        {
             result[r] = lst[midIndex];
        }
   }
    
    private static void BinarySortRemove(List<int> nums, int l, int r, int value)
    {
        if(r>=l)
        {
            int mid = l + (r - l)/2;
            if(nums[mid] == value)
            {
                 nums.RemoveAt(mid);
            }
            else if(value < nums[mid])
            {
                BinarySortRemove(nums, l, mid -1, value);
            }
            else
            {
                BinarySortRemove(nums, mid + 1, r, value);
            }
        }
        else
        {
            //nums.Insert(r+1, value);
            Console.WriteLine("NOT EXPECTED CODE PATH");
        }
    }
    
    private static void BinarySortInsert(List<int> nums, int l, int r, int value)
    {
        if(r>=l)
        {
            int mid = l + (r - l)/2;
            if(nums[mid] == value)
            {
                 nums.Insert(mid+1, value);
            }
            else if(value < nums[mid])
            {
                BinarySortInsert(nums, l, mid -1, value);
            }
            else
            {
                BinarySortInsert(nums, mid + 1, r, value);
            }
        }
        else
        {
            nums.Insert(r+1, value);
        }
    }