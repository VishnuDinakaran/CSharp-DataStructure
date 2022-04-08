<Query Kind="Program" />

void Main()
{
	string text = "CATCGGTCAG";
	
	Console.WriteLine($"{text[3]} ; L : {text.Length}");
	
	SuffixTreeNode root = new SuffixTreeNode('*', -1, 0, false, text);
	for(int i = text.Length-1; i >= 0; i--)
	{
	   root.AddSuffix(text[i], i, text.Length-1, false, text);
	}
	
}

// You can define other methods, fields, classes and namespaces here

public class SuffixTreeNode
{
   public SuffixTreeNode(char c, int cStrtIdx, int endIdx, bool isEdOfWrd, string txt)
   {
   		Text = txt;
   		Char = c;
		StartIdx = cStrtIdx;
		EndIdx = endIdx;
		IsEndOfSuffix = isEdOfWrd || cStrtIdx == endIdx;
		if(StartIdx == EndIdx && IsEndOfSuffix & Char != '$')
		  Char = '$';		
   }
   
   public bool Search(string s)
   {
     return false;
   }
   
   public bool AddSuffix(char c, int cStrtIdx, int endIdx, bool isEdOfWrd, string txt)
   {
       if(txt == null || txt.Length >= cStrtIdx || txt.Length >= endIdx || cStrtIdx < 0 || c != txt[cStrtIdx]) return false;
	     
	   
	   if(Char != c) //if this.Char is same as add char,
	   {	        // if more char after this start Index, create '$' to indicate existing suffix prior to this suffix text			
          if(endIdx > cStrtIdx) // 
		  {
		    SuffixTreeNode sTre = new SuffixTreeNode('$',StartIdx, EndIdx, true, txt);
		    IsEndOfSuffix = false;
		    Children.Add(Char, sTre);
		    cStrtIdx++;
		    this.AddSuffix(txt[cStrtIdx], cStrtIdx, endIdx, false, txt); // move to next char in the text to be added
		    return true;
		  }
		  else
		  {
		     this.IsEndOfSuffix = true; 
		     return true;
		  }
	   }
	  
	   // if new char , add as child to this node
	   SuffixTreeNode node = new SuffixTreeNode(txt[cStrtIdx], cStrtIdx, endIdx, cStrtIdx == endIdx, txt);
	   Children.Add(Char, node);
	   cStrtIdx++;
	   this.AddSuffix(txt[cStrtIdx], cStrtIdx, endIdx, false, txt); // move to next char in the text to be added
	   return true;
   }
   
   public int? Index { get; set; }
   
   public char Char { get; set; }   
   
   public string Text { get; set; }
   
   public int StartIdx { get; set; }
   
   public int EndIdx { get; set; }
   
   public bool IsEndOfSuffix { get; set; }
   
   public Dictionary<char, SuffixTreeNode> Children { get; set; }   
   
   public override string ToString()
   {
     List<string> dFNodes = new List<string>();
	 return "";
   }
}