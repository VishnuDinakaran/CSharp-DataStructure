<Query Kind="Program">
  <RuntimeVersion>6.0</RuntimeVersion>
</Query>

void Main()
{
    HashSet<int> h = new HashSet<int>();
	h.Contains(0);
	for(int i = 0; i < 5; i++)
	{
	  if(!h.Contains(i))
	  {
	    h.Add(i);
	  }
	}
	Console.WriteLine($"HashSet : {string.Join(", ", h.ToArray())}");
    
	List<int> l = new List<int>();
	
	for(int i = 0; i < 5; i++)
	{
	  l.Add(i);
	}
	
	 int j = l[l.Count-1];
	 l.RemoveAt(l.Count-1);
	 Console.WriteLine($" Count : {l.Count} ; j:{j}");
	
	
	int[] arr = {1,2,3};
	
	ListNode root = new ListNode(arr[0]);
	var lstRoot = root;
	for(int i = 1; i < arr.Length; i++)
	{
		ListNode n = new ListNode(arr[i]);
		root.next = n;
		root = n;
	}
	
	lstRoot.ToString();
	//Console.WriteLine($" Count : {l.Count} ; j:{j}");	
	
	ListNode ln = RotateList(lstRoot, 4);
	
	Console.WriteLine($" \n -------- ");
	
	ln.ToString();
}

private static ListNode RotateList(ListNode head, int k)
{
  if(head == null || head.next == null || k == 0) return head;
  
   
   MyList mLst = new MyList();
   while(head != null)
   {
     mLst.Push(head);
	 head = head.next;	 
   }
   int m = k < mLst.Count? k : k % mLst.Count;
   for(int i = 0; i < m; i++)
   {
     ListNode l = mLst.Pop();
	 l.next = mLst.Head();
	 mLst.Tail().next = null;
	 mLst.EnQ(l);
   }
  
   return mLst.Head();
}



public class MyList
{
  private List<ListNode> lst = new List<ListNode>();
  
  public int Count
  {
    get
    {
      return lst.Count;
	}
  }
  
  public void EnQ(ListNode lstN)
  {
     lst.Insert(0,lstN);
  }
  
  public void Push(ListNode lstN)
  {
     lst.Add(lstN);
  }
  
  public ListNode Pop()
  {
    ListNode r = lst.Count == 0 ? null : lst[lst.Count-1];
	lst.RemoveAt(lst.Count-1);
	return r;
  }
  
  public ListNode Head()
  {
     return lst[0];
  }
  
  public ListNode Tail()
  {
    return lst[lst.Count - 1];
  }
  
}

public class ListNode 
{
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
	  public override string ToString()
	  {
	     Console.Write($"{this.val}");
		 if(next != null) { Console.Write($"->"); next.ToString();}
	     return "";
	  }
  }
