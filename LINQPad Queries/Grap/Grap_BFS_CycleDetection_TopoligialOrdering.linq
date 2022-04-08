<Query Kind="Program" />

void Main()
{
	  // Create a graph given in the above diagram 
        Graph g = new Graph(6); 
        g.AddEdge(0, 1); 
        g.AddEdge(1, 2); 
        g.AddEdge(2, 0); 
        g.AddEdge(3, 4); 
        g.AddEdge(4, 5); 
  
        Console.WriteLine($"g.IsCyclicDetuctedByBFS() : {g.IsCyclicDetuctedByBFS()}");
}

public class Graph
{
	public int v { get; set; }
	
	public List<int>[] adj { get; set; }
	
	public Graph(int c)
	{
		v = c;
		adj = new List<int>[v];
		for(int i = 0; i < v; i++)
		{
			adj[i] = new List<int>();
		}
	}
	
	public void AddEdge(int idx, int v)
	{
		adj[idx].Add(v);
	}
	
	public bool IsCyclicDetuctedByBFS()
	{
		int[] inDegree = new int[v];		
		for(int i = 0; i < v; i++)
		{
			for(int j = 0; j < adj[i].Count; j++)
			{
				inDegree[adj[i][j]]++;
			}
		}
		Queue<int> q = new Queue<int>();
		Queue<int> topoligicalOrderQ = new Queue<int>();
		for(int i = 0; i < v; i++)
		{
			if(inDegree[i] == 0)
				q.Enqueue(i);
		}
		int ct = 0;
		while(q.Count > 0)
		{
			int vIdx = q.Dequeue();
			topoligicalOrderQ.Enqueue(vIdx);
			for(int i = 0; i < adj[vIdx].Count; i++)
			{
				if(--inDegree[adj[vIdx][i]] == 0)
					q.Enqueue(adj[vIdx][i]);
			}
			ct++;
		}
		Console.WriteLine($"Topoligical Order : {string.Join(", ", topoligicalOrderQ)}");
		if(ct == v)
			return false; // Acyclic Graph
		else  // ct != v
			return true;  // Cyclic Graph
		
		
	}
}
