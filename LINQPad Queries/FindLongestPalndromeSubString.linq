<Query Kind="Program" />

static void Main()
{
	System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
    #region Find Longest Palindrom Sub-String  
            List<string> vs = new List<string>() {
               "a", "aa", "bbbb","abbbb","abbbbb", "abbbbbb","abbb","aasdfbbb", "bbbb","bbbbb","abbc", "racecar", "aba", "abcdeffe", "abcdefff", "ddddd", "abcdefedcbxyz" };
            foreach (var item in vs)
            {
                sw.Start();
                Console.WriteLine($"FindLongestPalindromeSubStringUsingStack \"{item}\" - {string.Join(',', FindLongestPalindromeSubString(item))} -({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
                sw.Reset();
            }
            #endregion
	
}

private static int startCharIndex = 0;
private static int palindromeMaxLength = 0;
public static string FindLongestPalindromeSubString(string str)
{
startCharIndex = 0;
palindromeMaxLength = 0;
if (str == null || str.Length == 0) return string.Empty;
if (str.Length == 1) return str;

for(int i = 0; i < str.Length - 1; i++)
{
	//Expand from single character - if palindrom is made of odd number of charater string
	ExpandLeftAndRightOfStartAndEndCharIndexOfString(str, i, i);
	
	//Expand from double characters - if palindrom is made of even number of charater string
	ExpandLeftAndRightOfStartAndEndCharIndexOfString(str, i, i + 1); // since for loop is i < str.Length -1 we should be safe for i+1
}
 return str.Substring(startCharIndex, palindromeMaxLength);
}

private static void ExpandLeftAndRightOfStartAndEndCharIndexOfString(string str, int start, int end)
{
 // check if chars in start and end end index of the string are same
 while(start >= 0 && end < str.Length && str[start] == str[end])
 {
 	start--;
	end++;
 }
 // on while loop exit ; check if end-start index > existing palindromeMaxLength
 if (palindromeMaxLength < ((end - start) - 1)) // new length  is less than previous lenght; if yes proced else  ignore 
 {
 	startCharIndex = start + 1;   
	palindromeMaxLength = ((end - start) - 1); // new length (start-end)-1
 } 
}

public static string FindLongestPalindromeSubStringUsingStack(string str)
{
	if(str == null || str.Length == 0) return null;

	string longPalindromeStr = string.Empty; // use this same variable (longPalindromeStr.Length) to compare the palindrome length 
	//Eg
	//[r,a,c,e,c,a,r] [a,b,a] [a,b,c,d,e,f,f,e] [a,b,c,d,e,f,f,f] [a,b,c,d,e,f,e,d,c,g,h] [d,d,d,d]
	//[a,b,c,d,e,d,c,t,y,u]
	
	int i = 0,j = 1, startIndx = 0;    
	while(j < str.Length && i >= 0)
	{
		if(str[i] == str[j]) // is palindrome
		{
			j++;
			if (j-i > 2) i--;
		}	
		else if (j-i == 2)
		{ 
			i++;
		}
		else
		{
			if(j-i > 2 && longPalindromeStr.Length < j-1) // end of palinderome ; charecters i to j  form palindrome substring
			{
				
			}			
			j++;			
			// decide end of palinderome start and get i to j char to get palindrome
		}
	}	
	return longPalindromeStr;
}

