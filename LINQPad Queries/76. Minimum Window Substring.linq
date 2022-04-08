<Query Kind="Program" />


	void Main()
	{
		String s = "aaaaaaaaaaaabbbbbcdd";
		String t = "abcdd";
				
		//s = "ADOBECODEBANC";
		//t = "ABC";
		
		//s = "acbbaca";
		//t = "aba";
		
		//s="ab";
		//t="a";
		
		int  k = 0;
		while (k < t.Length)
		{
			Console.WriteLine($"{t[k]} - {t[k]-'0'}");
			k++;
		}
		Stopwatch sw =new Stopwatch();
		sw.Start();
		Console.WriteLine($"Inputs => s:{String.Join(" ", s.ToCharArray())} ; t:{t}");
		//Console.WriteLine($"Output => {MinWindowBruteForce(s, t)} - ({sw.ElapsedMilliseconds})ms ({sw.ElapsedTicks})t");
		Console.WriteLine($"Output => {MinWindow(s, t)} - ({sw.ElapsedMilliseconds})ms ({sw.ElapsedTicks})t");
		
		//NEXT : 718. Maximum Length of Repeated Subarray
	}
	
private static string MinWindow(string s, string t)
{
	if(s==null || t == null || s.Length == 0 || t.Length == 0) return "";
	if(s == t) return t;
	
	int tSum = 0;
	Dictionary<char, int> tD = new Dictionary<char, int>();
	for(int l = 0; l < t.Length; l++)
	{
		tSum += (t[l]-'0');
		if(tD.ContainsKey(t[l]))
			tD[t[l]]++;
		else
			tD.Add(t[l], 1);		
	}
	
	Dictionary<char, int> c = new Dictionary<char, int>();
	int i = 0, j = 0, tmpSum = 0, minL = int.MaxValue;
	string result = "";
	for(; i < s.Length; i++)
	{
		tmpSum = MovePtr1(tD, c, tmpSum, s[i]);	
		if(tmpSum == 0) j++;
		
		while(tmpSum == tSum) 
		{
			result = GetResultString(i, j, ref minL, s, ref result);
			// check and move j to next valid 
			tmpSum = MovePtrJ(tD, c, tmpSum, s, ref j , i);	
		}
	}
	while(j<=i-1)
	{		
		// check and move j to next valid 
		tmpSum = MovePtrJ(tD, c, tmpSum, s, ref j , i-1);
		if(tSum == tmpSum)
			result = GetResultString(i-1, j, ref minL, s, ref result);
	}
	return result;
}
	
private static int MovePtrJ(Dictionary<char, int> tD, Dictionary<char, int> c, int tmpSum, string s, ref int j, int i)
{		
	do
	{
		if(tD.ContainsKey(s[j]) && c.ContainsKey(s[j]))
		{				
			if(c[s[j]] > 1)
			{
				c[s[j]]--;
				if(tD[s[j]] > c[s[j]])
					tmpSum -= (s[j]-'0');
			}
			else 
			{
				c.Remove(s[j]);
				tmpSum -= (s[j]-'0');
			}	
		}
		j++;
	} while (j <= i && !tD.ContainsKey(s[j]));		
	return tmpSum;
}

private static int MovePtr1(Dictionary<char, int> tD, Dictionary<char, int> c, int tmpSum, char ch)
{
	if(tD.ContainsKey(ch))
	{
		if(!c.ContainsKey(ch))
		{
			c.Add(ch, 1);
			tmpSum += (ch-'0');
		}
		else 
		{
			c[ch]++;
			if (tD[ch] >= c[ch])
				tmpSum += (ch-'0');				
		}
	}
	return tmpSum;
}
	
private static string GetResultString(int i, int j, ref int minL, string s, ref string result)
{
	int m = (i+1)-j;
	if(m < minL)
	{
		minL = m;
		result = s.Substring(j, m); 
	}
	return result;
}
	
	
public string MinWindowBruteForce(string s, string t) 
{
    if(s == null || s.Length == 0 || t == null || t.Length == 0 || t.Length > s.Length) return "";
    if(t == s) return t;
            
    Dictionary<char, int> h = new Dictionary<char, int>();        
    for(int i = 0; i < t.Length; i++)   // m = t.Length ; O(m)
    {
        if(h.ContainsKey(t[i]))
        {
            h[t[i]]++;                
        }
        else
        {
            h.Add(t[i], 1);
        }
    }
    string result = "";
    int min = int.MaxValue;
    Dictionary<char, int> c = new Dictionary<char, int>(h); 
    for(int i = 0; i < s.Length; i++)   // n = s.Length ; O(n2)
    {
        c = new Dictionary<char, int>(h);
        if(c.ContainsKey(s[i]))
        {    
            if(c[s[i]] > 1) 
                c[s[i]]--;
            else
                c.Remove(s[i]);
            if(c.Count == 0) return $"{s[i]}";
            //Console.WriteLine($"s[i] => {string.Join(", ", c)} ; i:{i} ; s[i]:{s[i]}");                
            for(int j = i+1; j < s.Length; j++)
            {
                if(c.ContainsKey(s[j]))
                {
                    if(c[s[j]] > 1) 
                       c[s[j]]--;
                      else
                       c.Remove(s[j]);
                    //Console.WriteLine($" [j] => {string.Join(", ", c)} ; i:{i} ; j:{j} ; s[j]:{s[j]}"); 
                }
				
                if(c.Count == 0) //all t char met
                {
                    int m = (j+1)-i;
                    if(m < min)
                    {
                        min = m;
                        result = s.Substring(i,m);
                        //Console.WriteLine($"min:{min} ; result:{result} ; i:{i} ; j:{j}");
                    }
                    c = new Dictionary<char, int>(h);
                    c.Remove(s[i]);
                }     
            }   
        }
    }
    return result;
}
	
	