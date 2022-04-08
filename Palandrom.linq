<Query Kind="Program">
  <RuntimeVersion>6.0</RuntimeVersion>
</Query>

void Main()
{
	Console.WriteLine($"alpha = {  (char)(5 + (int)'a') }");
	
	string s = "0P";//"A man, a plan, a canal: Panama";
	Console.WriteLine($"IsPalindrome String : {s} => {IsPalindrome(s)}");
	
	int[] a = { 1,5,1};	
	ListNode l = new ListNode(a[0]);
	var ls = l;
	for(int i = 1; i < a.Length; i++)
	{
		ListNode ln = new ListNode(a[i]);
		l.next = ln;
		l= ln;
	}
	//Console.WriteLine($"IsPalindrome LinkedList : {string.Join(',', a)} => {IsPalindrome(ls)}");
	
	int x = 211252112;
	//Console.WriteLine($"IsPalindrome : {x} => {IsPalindrome(x)}");
	
}

 public bool IsPalindrome(string s) {
        
        if(s==null || s==string.Empty) return false;
        
        string rev = null;
        string str = null;
        
        for(int i = 0; i < s.Length; i++)
        {
            char c = new char();
            if(s[i] >= (int)'A' && s[i] <= (int)'Z')
            {
               int ch= ((int)s[i])-((int)'A') ;
               c = (char)(ch + (int)'a');               
               str += c;  			
			   rev = c + rev;
            }
            else if(s[i] >= (int)'a' && s[i] <= (int)'z')
            {
                c = s[i];
                str += c;  
				rev = c + rev;
            }      
			Console.WriteLine($"C: {c} ; Str : {str} ; Rev : {rev}");
        }
        Console.WriteLine(str);
        
        return str == rev;
        
    }

public bool IsPalindrome(int x)
{	   
   if(x>=0 && x < 10) return true;
   if(x%10 == 0) return false;
   
    int v = 0;
    while(x > v)
    {  
		int r = x % 10;		
        x = x/10;			
		v = (v*10) + r;
    }

    return x == v || x == v/10;
}

 public bool IsPalindrome(ListNode head)
 {
     if(head == null) return false;        
       
        int num = 0;
        int rev = 0;
        int mlpl = 1;
        
        while(head != null)
        {
            num = (num*10) + head.val;  
            rev = (head.val*mlpl) + rev;
            mlpl = mlpl * 10;
            head = head.next;
			Console.WriteLine($"num:{num} ; rev:{rev}");
        }
        Console.WriteLine($" => num:{num} ; rev:{rev}");
        return rev == num;
 }


//Definition for singly-linked list.
  public class ListNode
  {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) 
	  {
          this.val = val;
          this.next = next;
      }
  }
 

// You can define other methods, fields, classes and namespaces here