<Query Kind="Program" />

void Main()
{
	int[] unSortedArray = new int[]{7,8,5,2,4,6,3};	
//	Console.WriteLine($"unSortedArray : [{string.Join(", ", unSortedArray)}] ; Sorted=>[{string.Join(", ", InsertionSort(unSortedArray))}]");
	
	int[] unSortedArray1 = new int[]{6,5,3,1,8,7,2,4};
//	Console.WriteLine($"unSortedArray : [{string.Join(", ", unSortedArray1)}] ; Sorted=>[{string.Join(", ", InsertionSort(unSortedArray1))}]");
	
	ListNode ln1 = new ListNode(4);
	ListNode ln2 = new ListNode(2);
	ListNode ln3 = new ListNode(1);
	ListNode ln4 = new ListNode(3);
	ListNode ln5 = new ListNode(0);
	ln1.next = ln2;
	ln2.next = ln3;
	ln3.next = ln4;
	ln4.next = ln5;

	ListNode.Print(ln1);
	
	//ListNode.Print(InsertionSortList(ln1));
	ListNode.Print(InsertSortLinkedListV(ln1));
}

public static ListNode InsertSortLinkedListV(ListNode head)
{
	if (head == null) return null;
	
	ListNode dummy = new ListNode(0);
	ListNode cur = null;
	//cur is left sorted linked list and head is start of right side unsorted linked list
	//eg: 1->2->3->5 <-(9)     | 4->6->8->7
	while(head != null)
	{
		var temp = head.next;
		cur = dummy;
		while(cur.next != null && cur.next.val < head.val)
		{
			cur = cur.next;
		}
		head.next = cur.next;
		cur.next = head;
		head = temp;
	}	
	return dummy.next;	
}


private static int[] InsertionSort(int[] nums)
{
	//i => start index of unsortedArray
	for(int i = 1; i < nums.Length; i++)
	{
		int k = i;
		for(int j = k-1; j >= 0; j--)
		{
			if(nums[j] > nums[k])
			{
				//swap
				int temp = nums[k];
				nums[k] = nums[j];
				nums[j] = temp;
			}
			else
			{
				j = -1; //break
			}
			k = j;
		}
	}
	return nums;
}

 public static ListNode InsertionSortLinkedList(ListNode head) {
        ListNode dummy = new ListNode(0);
                ListNode cur = dummy;
                while (head != null) {
                    var tmp = head.next;
                    cur = dummy;
                    while (cur.next != null && cur.next.val < head.val) {
                        cur = cur.next;
                    }
                    head.next = cur.next;
                    cur.next = head;
                    
                    head = tmp;
                }
                return dummy.next;
    }
   

public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
	 public override string ToString()
	 {
	 	return val.ToString();
	 }
	 
	 public static void Print(ListNode ln1)
	 {
 		Console.Write($"Linked List :  [{ln1}");
		ListNode nxt = ln1.next;
		//Console.WriteLine($"");
		while(nxt != null)
		{
			Console.Write($"->{nxt}");
			nxt = nxt.next;
		}
		Console.WriteLine($"]");			
	 }
 }
