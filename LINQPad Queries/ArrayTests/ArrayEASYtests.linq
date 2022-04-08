<Query Kind="Program" />

void Main()
{
System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
 sw.Start();
            Console.WriteLine($"FindFirstDuplicateInt - {FindFirstDuplicateInt(new int[] {2,1,3,5,3,2,1,4,5 })} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();

}


      public static int FindFirstDuplicateInt(int[] nums)
        {
            if (nums.Length == 0) return -1;

            int[] len = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (len[Math.Abs(nums[i]) - 1] < 0)
                {
                    return Math.Abs(nums[i]);
                }
                else
                {
                    len[Math.Abs(nums[i]) - 1] = -len[Math.Abs(nums[i]) - 1];
                }

            }
            return -1;
        }