<Query Kind="Program" />

   static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int count = 0;
            int N = 20;
            for (int i = N; i > 0; i /= 2)
                for (int j = 0; j < i; j++)
                    count++;
            Console.WriteLine($"{count}");

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            #region SumOfTwo Return Indices
            int targetSum = 1999;
            int[] inputArr = new int[1001];
            for (int i = 0; i < 1001; i++)
            {
                inputArr[i] = i;
            }
            sw.Start();
            Console.WriteLine($"GetSumTwoIndexOnePass - {string.Join(',', GetSumTwoIndexOnePass(inputArr, targetSum))} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
            sw.Start();
            Console.WriteLine($"GetSumTwoIndex Brute Force - {string.Join(',', GetSumTwoIndex(inputArr, targetSum))} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
            #endregion

            #region RemoveDuplicate on sorted int[] and return arr length

            int[] dupArr = new int[] { 0, 1, 1, 2, 2, 3, 3, 3 };
            sw.Start();
            Console.WriteLine($"RemoveDuplicate Brute Force - {RemoveDuplicate(dupArr)} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
            int[] dupArr1 = new int[] { 0, 1, 1, 2, 2, 3, 3, 3 };
            sw.Start();
            Console.WriteLine($"RemoveDuplicates Brute Force - {removeDuplicates(dupArr)} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
            #endregion

            #region FirstNonRepeatingCharOnAString
            sw.Start();
            Console.WriteLine($"FirstNonRepeatingCharOnAString - {FirstNonRepeatingCharOnAString("abcbad")} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
            sw.Start();
            Console.WriteLine($"FirstNonRepeatingCharOnAString - {FirstNonRepeatingCharOnAString("aaaaaabbbbccbbaaddef")} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
            sw.Start();
            Console.WriteLine($"FirstNonRepeatingCharOnAString26 - {FirstNonRepeatingCharOnAString26("aaaaaabbbbccbbaaddef")} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
            #endregion
        }

        #region SumOfTwo Return Indices
        //time complexity is O(n2) 
        public static int[] GetSumTwoIndex(int[] array, int sum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] == sum - array[j])
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            throw new Exception("no Sum Exist!");
        }

        //time complexity is O(n) 
        public static int[] GetSumTwoIndexOnePass(int[] array, int sum)
        {
            System.Collections.Generic.Dictionary<int, int> dict = new System.Collections.Generic.Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                var v = sum - array[i];
                if (dict.ContainsKey(v))//.TryGetValue(sum-array[i], out var v))
                {
                    return new int[2] { dict[v], i };
                }
                else
                {
                    dict.Add(array[i], i);
                }

            }
            throw new Exception("no Sum Exist!");
        }

        #endregion

        #region RemoveDuplicate on sorted int[] and return arr length
        //incoming sorted array find duplicate, return length after removing duplicate 
        public static int RemoveDuplicate(int[] arr)
        {
            if (arr.Length == 0) return 0;
            int i = 0; // pointer (index)
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[i] != arr[j])
                {
                    i++;
                    arr[i] = arr[j];
                }
            }
            return i + 1;
        }

        public static int removeDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
        #endregion

        #region FirstNonRepeatingCharOnAString
        public static char FirstNonRepeatingCharOnAString(string str)
        {
            if (str == null || str.Length == 0) return '_';

            Dictionary<char, int> charsInStr = new Dictionary<char, int>();
            // O(n) - time complexity 
            for (int j = 0; j < str.Length; j++)
            {
                if (charsInStr.ContainsKey(str[j]))
                {
                    charsInStr[str[j]]++;
                }
                else
                {
                    charsInStr.Add(str[j], 1);
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (charsInStr[str[i]] == 1)
                {
                    return str[i];
                }
            }

            return '_';
        }

        public static char FirstNonRepeatingCharOnAString26(string str)
        {
            if (str == null || str.Length == 0)
            {
                return '_';
            }

            int[] chars = new int[26];

            for (int i = 0; i < str.Length; i++)
            {
                chars[str[i] - 'a']++;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (chars[str[i] - 'a'] == 1)
                {
                    return str[i];
                }
            }

            return '_';
        }
        #endregion