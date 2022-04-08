<Query Kind="Program" />

void Main()
{	
	Console.WriteLine(" ");	
	TreeNode root1 = new TreeNode(5);	
	TreeHelper.InOrderInsert(root1, new int[]{6,4,9,3,2,1,8,7,10});	
	Console.WriteLine(" ");	
	Console.WriteLine($" Height of root1 : {TreeHelper.GetHeight(root1)}");	
	Console.WriteLine(" ");	
	Console.WriteLine($" Print Given Levle : ");
	TreeHelper.PrintLevel(root1);
	
	
	Console.WriteLine(" ");	
	Console.WriteLine(" Print InOrder ");	
	TreeHelper.PrintInOrder(root1);
	Console.WriteLine(" ");	
	Console.WriteLine(" Print Post Order ");
	TreeHelper.PrintPostOrder(root1);
	Console.WriteLine(" ");	
	Console.WriteLine(" Print Pre Order ");
	TreeHelper.PrintPreOrder(root1);	
	
	Console.WriteLine(" ");	
	Console.WriteLine($"Get Min : {TreeHelper.GetMin(root1)}");
	
	Console.WriteLine(" ");	
	Console.WriteLine($"Get Max : {TreeHelper.GetMax(root1)}");
	
	Console.WriteLine(" ");	
	Console.WriteLine($"Search : {TreeHelper.Search(root1, 9)}");
	
	
	Console.WriteLine(" PRINT CUSTOM MADE TREE ");
	
    TreeNode rootT = new TreeNode(1);
    rootT.Left = new TreeNode(2);
    rootT.Right = new TreeNode(3);
    rootT.Left.Left = new TreeNode(4);
    rootT.Left.Right = new TreeNode(5);	
	 rootT.Left.Left.Right = new TreeNode(6);	 
	 rootT.Left.Right.Left = new TreeNode(7);
	 rootT.Left.Right.Right = new TreeNode(8);
	 rootT.Right.Left = new TreeNode(9);
	 rootT.Right.Right = new TreeNode(10);
	 
	Console.WriteLine(" ");
    Console.WriteLine(" Print InOrder ");
    TreeHelper.PrintInOrder(rootT);
	Console.WriteLine(" ");
	Console.WriteLine(" Print InOrder Traversal ");
	TreeHelper.PrintInOrderTraversal(rootT);
    Console.WriteLine(" ");
    Console.WriteLine(" Print Pre Order ");
    TreeHelper.PrintPreOrder(rootT);
	Console.WriteLine(" ");
	Console.WriteLine(" Print Preorder Traversal ");
	TreeHelper.PreorderTraversal(rootT);
    Console.WriteLine(" ");
    Console.WriteLine(" Print Post Order ");
    TreeHelper.PrintPostOrder(rootT);
	Console.WriteLine(" ");
	Console.WriteLine(" Print Post Order Traversal ");
    Console.WriteLine(string.Join(", ", TreeHelper.PostorderTraversal(rootT)));
}

public class TreeNode
{
	public int Data { get; set; }
	public TreeNode Left { get; set; }
	public TreeNode Right { get; set; }
	
	public TreeNode(int val)
	{
		Data = val;		
	}	
	public override string ToString()
    {
        return $"{Data} ; L:{Left?.Data} R:{Right?.Data}";
    }
}

public class BinaryTree
{
	public TreeNode Root { get; private set; }
}

/*
//Tree Traversal
InOrder    - Left, Root, Right
Pre-Order  - Root, Left, Right
PostOrder  - Left, Right, Root
*/
public static class TreeHelper
{

	public static void PrintLevel(TreeNode root)
	{
		int h = GetHeight(root);
		for(int i = 1; i <= h; i++)
		{
			PrintGivenLevelOrder(root, i);
			Console.WriteLine("");
		}
	}
	
	public static void PrintGivenLevelOrder(TreeNode root, int level)
	{
		if(root == null) return;
		if(level == 1) Console.Write($"{root.Data} ");
		else if(level > 1)
		{
			PrintGivenLevelOrder(root.Left, level -1);
			PrintGivenLevelOrder(root.Right, level -1);			
		}
	}

	public static int GetHeight(TreeNode root)
	{
		if(root == null) return 0;
		else
		{
			int lHeight =  GetHeight(root.Left);
			int rHeight =  GetHeight(root.Right);
			if(lHeight > rHeight) return (lHeight + 1);
			else return (rHeight + 1);
		}	
	}

	public static TreeNode Search(TreeNode root, int val)
	{		
		if (root == null) return null;
		
		if(val == root.Data) return root;
		if (val < root.Data)
		{
			return Search(root.Left, val);
		}
		else
		{
			return Search(root.Right, val);
		}		
	}
	
	public static TreeNode GetMin(TreeNode root)
	{
		TreeNode result = null;
		if(root == null) return null;
		if(root.Left == null) result =  root;
		else result = GetMin(root.Left);
		return result;
	}
	
	public static TreeNode GetMax(TreeNode root)
	{
		if(root == null) return null;
		if(root.Right != null) return GetMax(root.Right);
		else return root;
	}

	public static TreeNode InOrderInsert(TreeNode root, int[] nums)
	{
		for(int i = 0; i < nums.Length; i++)
		{
			root = InOrderInsert(root, nums[i]);
		}
		return root;
	}
	// InOrder Insert
	public static TreeNode InOrderInsert(TreeNode root, int value)
	{
	   if(root == null) return new TreeNode(value);
	   
	   if(value < root.Data) 
	   {
	   		root.Left = InOrderInsert(root.Left, value);
	   }
	   else
	   {
	   		root.Right = InOrderInsert(root.Right, value);
	   }
	   return root;
	}

	// InOrder 
	//// Left, Root & Right
	public static void PrintInOrder(TreeNode node)
	{	
		if(node == null) return;
		PrintInOrder(node.Left);
		Console.Write($"{node.Data}, ");
		PrintInOrder(node.Right);		
	}
	
	public static List<int> PrintInOrderTraversal(TreeNode root)
	{	
		List<int> result = new List<int>();
		Stack<TreeNode> s = new Stack<TreeNode>();
		TreeNode curr = root;
		//Left root right
		while(s.Count > 0 || curr != null)
		{
			//get to left most leaf - push all into the stack
			while(curr != null)
			{
				s.Push(curr);
				curr = curr.Left;
			}
			curr = s.Pop();
			Console.Write($"{curr.Data}, ");
			result.Add(root.Data);
			curr = curr.Right;
		}		
		return result;
	}
	
	// Pre-Order 
	//// Root, Left & Right
	public static void PrintPreOrder(TreeNode node)
	{		
		if(node == null) return ;
		Console.Write($"{node.Data}, ");
		PrintPreOrder(node.Left);
	    PrintPreOrder(node.Right);	
	}
	
	public static IList<int> PreorderTraversal(TreeNode root) {
        //Pre-Order : Root, Left & Right
        IList<int> result = new List<int>();        
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode curr = root;
        
        while(curr != null || s.Count > 0)
        {
            while(curr != null)
            {
                s.Push(curr);
                result.Add(curr.Data);
                curr = curr.Left;
            }
            curr = s.Pop();
            curr = curr.Right;            
        }        
        return result;
    }
	
	// Post-Order 
	//// Left, Right & Root
	public static void PrintPostOrder(TreeNode node)
	{	
		if(node == null) return;
		PrintPostOrder(node.Left);
		PrintPostOrder(node.Right);	
		Console.Write($"{node.Data}, ");
	}
	
	public static IList<int> PostorderTraversal(TreeNode root)
	{
        //Post-Orde ; Left , Right , Root
        IList<int> result = new List<int>();
        if(root == null) return result;
        
        TreeNode curr = root;
        Stack<TreeNode> s = new Stack<TreeNode>();
        Stack<TreeNode> resS = new Stack<TreeNode>();
        
        while(curr != null || s.Count > 0)
        {
            while(curr != null)
            {
                s.Push(curr);
                curr = curr.Left;
            }
           TreeNode n = s.Peek();
            if(n.Right == null)
            {
                result.Add(n.Data);
                resS.Push(s.Pop()); 
                curr = null;
            }
            else
            {
                if((resS.Count > 0 &&  resS.Peek() != n.Right) || resS.Count == 0) curr = n.Right;
                else 
                {
                    curr = s.Pop();
                    resS.Push(curr);
                    result.Add(curr.Data);
                    curr = null;
                }
            }
        }        
        return result;        
    }
}

// Define other methods, classes and namespaces here