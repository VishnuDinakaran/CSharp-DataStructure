<Query Kind="Program" />

void Main()
{
	//Cyclic Grap
	Grap cg = new Grap(4);
	cg.AddEdge(0, 1);
	cg.AddEdge(0, 2);	
	cg.AddEdge(1, 2);	
	cg.AddEdge(2, 0);
	cg.AddEdge(2, 3);	
	cg.AddEdge(3, 3);
	
	Console.WriteLine($"START DFS => Graph");
	Console.WriteLine($"  . Is cg Cyclic : '{cg.CyclicUsingDFS()}'");
	Console.WriteLine($"END DFS => Graph");
	Console.WriteLine($" ");
	Console.WriteLine($"START BFS => Graph");
	Console.WriteLine($"  . Is cg Cyclic : '{cg.IsCyclicDetuctedByBFS()}'");
	Console.WriteLine($"END BFS => Graph");
	
	Console.WriteLine($" ");
	
	//Acyclic Grap
	Grap acg = new Grap(4);
	acg.AddEdge(0, 1);
	acg.AddEdge(0, 2);	
	acg.AddEdge(1, 2);	
	acg.AddEdge(2, 3);
	
	Console.WriteLine($"START DFS => Graph");
	Console.WriteLine($"  . Is acg Cyclic : {acg.CyclicUsingDFS()}");	
	Console.WriteLine($"END DFS => Graph");
	Console.WriteLine($" ");
	Console.WriteLine($"START BFS => Graph");
	Console.WriteLine($"  . Is acg Cyclic : '{acg.IsCyclicDetuctedByBFS()}'");
	Console.WriteLine($"END BFS => Graph");
	
	// Dept First Search
	// Breath  First Search 	
}

//
public class Grap
{
	public int Vertix { get; set; }
	public List<int>[] AdjacencyList { get; set; }
	
	public Grap(int v)
	{
		Vertix = v;
		AdjacencyList = new List<int>[Vertix];
		for(int i =0; i < v; i++)
		{	
			AdjacencyList[i] = new List<int>();
		}
	}
	
	public void AddEdge(int vIdx, int v)
	{
		AdjacencyList[vIdx].Add(v);
	}
	
	public bool CyclicUsingDFS()
	{
		bool[] visited = new bool[Vertix];
		bool[] recyStack = new bool[Vertix];
		
		//Console.WriteLine($"  ");
		for(int i = 0; i < Vertix; i++)
		{			
			//Console.WriteLine($"  ");
			if(IsCyclicDFS(i, visited, recyStack))
				return true;
		}		
		return false;
	}
	
	private bool IsCyclicDFS(int idx, bool[] visited, bool[] recyStack)
	{			
		if(recyStack[idx])
		{ 
			Console.Write($"{idx}->");	
			return true;
		}
		if(visited[idx])
			return false;
			
		Console.Write($"{idx}->");			
		visited[idx] = true;
		recyStack[idx] = true;
		
		for(int i = 0; i < AdjacencyList[idx].Count; i++)
		{
			if(IsCyclicDFS(AdjacencyList[idx][i], visited, recyStack))
				return true;
		}
		recyStack[idx] = false;
		return false;
	}
	
	public bool IsCyclicDetuctedByBFS()
	{
		int[] inDegree = new int[Vertix];		
		for(int i = 0; i < Vertix; i++)
		{
			for(int j = 0; j < AdjacencyList[i].Count; j++)
			{
				inDegree[AdjacencyList[i][j]]++;
			}
		}
		Queue<int> q = new Queue<int>();
		Queue<int> topoligicalOrderQ = new Queue<int>();
		for(int i = 0; i < Vertix; i++)
		{
			if(inDegree[i] == 0)
				q.Enqueue(i);
		}
		int ct = 0;
		while(q.Count > 0)
		{
			int vIdx = q.Dequeue();
			topoligicalOrderQ.Enqueue(vIdx);
			for(int i = 0; i < AdjacencyList[vIdx].Count; i++)
			{
				if(--inDegree[AdjacencyList[vIdx][i]] == 0)
					q.Enqueue(AdjacencyList[vIdx][i]);
			}
			ct++;
		}
		Console.WriteLine($"Topoligical Order : {string.Join(", ", topoligicalOrderQ)}");
		if(ct == Vertix)
			return false; // Acyclic Graph
		else  // ct != v
			return true;  // Cyclic Graph
		
		
	}
}