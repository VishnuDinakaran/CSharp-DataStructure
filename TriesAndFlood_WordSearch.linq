<Query Kind="Program" />

void Main()
{
	TrieNode root = new TrieNode('*', false);
	root.AddChild("Vishnu", 0);
	root.AddChild("Vignajith", 0);
	root.AddChild("Vidhula", 0);
	root.AddChild("Vidhla", 0);
	
	//root.ToString();	
	string s = "Vidla";
	Console.WriteLine($" Contains '{s}' : {root.Search(s)}");
}

/*
    _________________
	| map | Char	|
	|	  |			|
	| a	  |			|
	| b	  |		*	|
	| c	  |			|
	|	  |			|
	|_______________|
	|_Is End Of Wrd_|


*/

 public IList<string> FindWords(char[][] board, string[] words) {
        
        TrieNode root = new TrieNode('*', false);

        for(int i = 0; i < words.Length; i++)
        {
            root.AddChild(words[i], 0);
        }     
        
        IList<string> rst = new List<string>();
        
        for(int r = 0; r < board.Length; r++)
        {
            for(int c = 0; c < board[r].Length; c++)
            {
                if(root.Children.TryGetValue(board[r][c], out TrieNode t))
                {
                    HashSet<int> h =  new HashSet<int>();
                    h.Add((10*r)+c);
                    (bool result, StringBuilder str) = Flood(board, t, 'R', new StringBuilder(board[r][c]), h);
                    if(result)
                        rst.Add(str.ToString());
                }
            }
        }
        
        return rst;        
    }
    
    private static (bool r, StringBuilder s) Flood(char[][] b, TrieNode t, char eD, StringBuilder s, HashSet<int> vCell)
    {
       return (false, s);
    }
    



public class TrieNode
{
	public char C { get;set; }
	public Dictionary<char, TrieNode> Children { get; set; }
	public Dictionary<char, TrieNode> Prefixes { get; set; }
	public bool IsEndOfWord { get; set; }
	
	public TrieNode(char c, bool isWord)
	{
	   C = c;
	   Children = new Dictionary<char, TrieNode>();
	   Prefixes = new Dictionary<char, TrieNode>();
	   IsEndOfWord = isWord;
	}
	
	public bool Search(string s, int idx = 0)
	{
	  if(string.IsNullOrWhiteSpace(s) || idx >= s.Length) return false;
	  
	  if(Children.TryGetValue(s[idx], out TrieNode t))
	  {	     
	     //Console.Write($" {s[idx]} ");
	  
	     if(s.Length == idx+1 && t.IsEndOfWord) return true;
		 else return t.Search(s, ++idx);
	  }
	  
	  return false;
	}
	
	public void AddChild(string s, int idx)
	{
	   if(string.IsNullOrWhiteSpace(s) || idx >= s.Length || idx < 0) return;
	   
	   bool isLast = (s.Length == idx+1);
	   
	   TrieNode t = null;
	   if(Children.TryGetValue(s[idx], out t))
	   {
	       if(isLast) t.IsEndOfWord = true;
	   }
	   else
	   {
	      t = new TrieNode(s[idx], isLast);
	      Children.Add(s[idx], t);
	   }
	   if(!isLast) t.AddChild(s, ++idx);
	}
	
	public override string ToString()
	{
	  Console.WriteLine($"{C} - {IsEndOfWord}");
	  foreach(var t in Children)
	  {
	     t.Value.ToString();
	  }
	  return C.ToString();
	}
}

// You can define other methods, fields, classes and namespaces here