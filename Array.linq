<Query Kind="Program" />

void Main()
{
	
	    char[][] c = {   new Char[]{'5','3','.','.','7','.','.','.','.'}
						,new Char[]{'6','.','.','1','9','5','.','.','.'}
						,new Char[]{'.','9','8','.','.','.','.','6','.'}
						,new Char[]{'8','.','.','.','6','.','.','.','3'}
						,new Char[]{'4','.','.','8','.','3','.','.','1'}
						,new Char[]{'7','.','.','.','2','.','.','.','6'}
						,new Char[]{'.','6','.','.','.','.','2','8','.'}
						,new Char[]{'.','.','.','4','1','9','.','.','5'}
						,new Char[]{'.','.','.','.','8','.','.','7','9'}};
		
		Console.WriteLine($"IsValidSudoku : {IsValidSudoku(c)}");
}


 public bool IsValidSudoku(char[][] board) {
        if(board.Length != 9) return false;
        
        //Dictionary<int, HashSet<char>> row = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> clmn = new Dictionary<int, HashSet<char>>();        
        Dictionary<int, HashSet<char>> cub = new Dictionary<int, HashSet<char>>();
        
		int cubR = 1;
	    int R = 1;		
        for(int i = 0; i < 9; i++)
        {
            HashSet<char> r = new HashSet<char>();
            //row.Add(i, r);
			
			if(cubR == 4)
			{	
			  cubR = 1;
			  R++;
			  //Console.WriteLine($" Cub R : {R} ; ");
			}
			
			int cubClm = 1;
			int cl = 1;
            for(int j = 0; j < 9; j++)
            {
			    if(cubClm == 4)
				{
				  cubClm = 1;
				  cl++;
				}
				  
                if(board[i][j] != '.')
                {
				    //Row
                    if(r.Contains(board[i][j]))
                    {
                        return false;
                    }
                    else
                    {
                        r.Add(board[i][j]);
                    }
					
					//Column
					HashSet<char> c = null;
	                if(clmn.ContainsKey(j))
	                {
	                   c = clmn[j] ;
	                }
	                else
	                {
	                  c = new HashSet<char>();
	                  clmn.Add(j, c);
	                }
	                 
					if(c.Contains(board[i][j]))
					   return false;
					else
					  c.Add(board[i][j]);
					  
					//cube
					HashSet<char> cubV = null;
					if(cub.ContainsKey((R*10)+cl))
					{
					   cubV = cub[(R*10)+cl];
					}
					else
					{
					   cubV = new HashSet<char>();
	                   cub.Add((R*10)+cl, cubV);
					}
					if(cubV.Contains(board[i][j]))
					   return false;
					else
					  cubV.Add(board[i][j]);
	            }
				cubClm++;
            }
				cubR++;
				r.Clear();
				r = null;
        }
		
        return true;
    }
	
	 public void Merge(int[] nums1, int m, int[] nums2, int n)
	 {
        if(nums1.Length == 0 || nums2.Length == 0) return;
        
        int p1 = 0;
        int p2 = 0;
        
        while(p1 < nums1.Length && p2 < n)
        {
            if(p1 >= m)
            {
               // just move nums[p2] to nums1[p1] && increment both p1 & p2
               nums1[p1] = nums2[p2];
               p1++; p2++;
            }
            else if(nums1[p1] > nums2[p2])
            {
                //swap & sort nums2[]
                int t = nums1[p1];
                nums1[p1] = nums2[p2];
                nums2[p2] = t;
                InplaceSort(nums2);
                p1++;
            }
            else
            {
               // increment p1
                p1++;
            }
        }        
    }
    
    private static int[] InplaceSort(int[] n2)
    {   
        for(int i = 1; i < n2.Length; i++)
        {
            if(n2[i-1] > n2[i])
            {
                //swap
                int t = n2[i-1];
                n2[i-1] = n2[i];
                n2[i] = t;
            }
            else break;
        }
        return n2;
    }

// You can define other methods, fields, classes and namespaces here