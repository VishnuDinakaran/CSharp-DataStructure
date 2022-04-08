<Query Kind="Program" />

void Main()
{
	string s = "Vishnu";
	Console.WriteLine($"IndexOf : {s.IndexOf("")}");
	
	int[] i = new int[s.Length];
	Console.WriteLine($"{string.Join(", ", i)}");
	
	Console.WriteLine($"WordPattern  : {WordPattern("abba", "go dad dad go go")}");
}

// You can define other methods, fields, classes and namespaces here
 public bool WordPattern(string pattern, string s) {
        
        int[] a = new int[pattern.Length];
        Dictionary<char, int> cD = new Dictionary<char, int>();
        
        for(int i=0; i < pattern.Length; i++)
        {
            int c = 0;
            if(cD.ContainsKey(pattern[i]))
            {
                c = cD[pattern[i]];
            }
            else
            {
                c = cD.Count;
                cD.Add(pattern[i], c);
            }
            a[i] = c;
        }
        
        int sC = 0;
        Dictionary<string, int> sD = new Dictionary<string, int>();
        StringBuilder sB = new StringBuilder();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != ' ')
            {
                sB.Append(s[i]);
            }
            if (s[i] == ' ' || i == s.Length - 1)
            {
                string str = sB.ToString();
                if(sD.ContainsKey(str))
                {
                    if(sC >= a.Length || a[sC] != sD[str]) return false;
                }
                else
                {
                    sD.Add(str, sD.Count);
					if(sC >= a.Length || a[sC] != sD[str]) return false;
                }
                sB = new StringBuilder();
				sC++;
            }
        }        
        return cD.Count == sD.Count && true;        
    }

public int PatternMatching(string h, string n)
{
  if(string.IsNullOrEmpty(n)) return 0;
    
  int p = 0;
  
  for(int i = 0; i < h.Length; i++)
  {
     if(h[i] == n[p]) 
	 {
	 	p++;
	 }
	 else if(p > 0)
	 {
	   for(int j = p; j < 1; j--) 
	   {
	      if(h[i] == n[j])
		  {
		    
		  }
	   }
	 }
  }
  
  return -1;
}



// WordSearch in two-dimensional array 
    
    private static List<char> sides = new List<char>{'R', 'L', 'B', 'T'};
    
     public bool Exist(char[][] board, string word) {
        
        if(word.Length > (board.Length * board[0].Length)) return false;
        
        HashSet<int> h = new HashSet<int>();        
        int wP = 0;
        for(int r = 0; r < board.Length ; r++)
        {
            for(int c = 0; c < board[r].Length; c++)
            {
                if(Flood('R', board, r, c, word, wP, h))
                {  return true; }
                else
                {
                    wP = 0; h.Clear();// = new HashSet<int>();
                }
            }            
        }  
        
        return false;
    }
    
        
    private bool Flood(char eD, char[][] b, int rI, int cI, string w, int pW, HashSet<int> h)
    {
       
        if(rI >= b.Length || rI < 0 || cI < 0 || b[rI].Length <= cI || pW < 0 || pW >= w.Length) return false;
        
        bool rtn = false;
        if(w[pW] == b[rI][cI] && !h.Contains((10*rI)+cI))
        {
            h.Add((10*rI)+cI);
            pW++;            
            if(w.Length == pW) return true; // full string matched  
            
            foreach(char sd in sides)
            {
                    if(sd == 'R')
                    {
                        cI++;
                        if(!Flood(sd, b, rI, cI, w, pW, h))
                        {  
                            cI--; 
                        }
                        else
                        {   
                            return true;
                        }
                    }
                    if(sd == 'L')
                    {
                        cI--;
                        if(!Flood(sd, b, rI, cI, w, pW, h))
                        {                            
                            cI++;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    if(sd == 'B')
                    {
                        rI++;
                        if(!Flood(sd, b, rI, cI, w, pW, h))
                        {   
                            rI--;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    if(sd == 'T')
                    {
                        rI--;
                        if(!Flood(sd, b, rI, cI, w, pW, h))
                        {                          
                            rI++;
                        }
                        else
                        {
                            return true;
                        }
                    }
            }
            
            //After no way out from this cell , rewind/reverce 
            if(!rtn && h.Contains((10*rI)+cI))
            {
                h.Remove((10*rI)+cI);
                if(pW > 0) pW--;
            }
        }
        return rtn;
    }