<Query Kind="Program" />

using System.Linq;

void Main()
{
	TrieNode root = new TrieNode();
	root.C ='*';
	
	root.Search("CAT", 0);	
	root.Search("CAP", 0);	
	root.Search("CAMERA", 0);
	root.Search("CATERPILLAR", 0);
	root.Search("CAGE", 0);
	
	
	string srchStr = "CA";
	var rslt = root.Search(srchStr, 0);
	Console.WriteLine($"   {srchStr} ; Count : {rslt.Children.Count}");
}

public class TrieNode
{
	public char C { get; set; }
	public Dictionary<char, TrieNode> Children { get; private set; } 
	public bool IsWord {get; set;}
	
	public TrieNode()
	{
		Children = new Dictionary<char, TrieNode>();
	}
		
	public TrieNode Search(string s, int nxtIndx)
	{
		if(s.Length > nxtIndx)
		{
			if(Children.TryGetValue(s[nxtIndx], out var val))
			{				
				return val.Search(s, ++nxtIndx);
			} 
			else 
			{
				AddNew(s,nxtIndx);
				return this;
			}
		}
		return this;
	}
	
	internal void AddNew(string s, int nxtIndx)
	{
		if(s.Length > nxtIndx)
		{
		    bool lastChar = s.Length == nxtIndx;
			TrieNode node = new TrieNode { C = s[nxtIndx] , IsWord = lastChar };
			Children.Add(s[nxtIndx], node);
			if(!lastChar)
			{
				node.AddNew(s, ++nxtIndx);				
			}
		}
	}
}

// You can define other methods, fields, classes and namespaces here
