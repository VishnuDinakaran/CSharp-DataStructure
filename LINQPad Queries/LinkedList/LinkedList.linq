<Query Kind="Program" />

void Main()
{
	System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
	
	#region Binary Search LinkedList
		// TO DO
	#endregion 
	
			
			#region find Middle of the Linked List
		    Console.WriteLine($"START =>  Find Middle of the LinkedList :");
            ListNode ln11 = new ListNode(6);
            ListNode ln12 = new ListNode(5);
            ListNode ln13 = new ListNode(3);
            ListNode ln14 = new ListNode(1);
            ListNode ln15 = new ListNode(8);
            ListNode ln16 = new ListNode(7);
            ListNode ln17 = new ListNode(2);
            ListNode ln18 = new ListNode(4);
            ListNode ln19 = new ListNode(0);
            ln11.next = ln12;
            ln12.next = ln13;
            ln13.next = ln14;
            ln14.next = ln15;
            ln15.next = ln16;
            ln16.next = ln17;
            ln17.next = ln18;
            ln18.next = ln19;
			Console.Write($" {ln11.Print()}");
						
			ListNode p2 = FindMiddleOfLinkedList(ln11);
					
			Console.WriteLine($" Linked List Mid = {p2.val}");
			
			Console.WriteLine($"END =>  Find Middle of the LinkedList ");
			Console.WriteLine($"  ");
	#endregion

            #region DetectCycle in circular LinkedList
            Console.WriteLine("START =>  DetectCycle in circular LinkedList");
			ln19.next = ln12;
            Console.WriteLine($"DetectCycle : {DetectCycle(ln11)?.val}");

            Console.WriteLine("END =>  DetectCycle in circular LinkedList");
			Console.WriteLine($"  ");
            #endregion

            #region Merge Sort LinkedList // effecient way to sort LinkedList

            #endregion

            #region Insert Sort Linked List
            Console.WriteLine("START => Insertion sort => Linked List ;");
            ListNode ln1 = new ListNode(6);
            ListNode ln2 = new ListNode(5);
            ListNode ln3 = new ListNode(3);
            ListNode ln4 = new ListNode(1);
            ListNode ln5 = new ListNode(8);
            ListNode ln6 = new ListNode(7);
            ListNode ln7 = new ListNode(2);
            ListNode ln8 = new ListNode(4);
            ListNode ln9 = new ListNode(0);
            ln1.next = ln2;
            ln2.next = ln3;
            ln3.next = ln4;
            ln4.next = ln5;
            ln5.next = ln6;
            ln6.next = ln7;
            ln7.next = ln8;
            ln8.next = ln9;

            ln1.Print();
            InsertSortLinkedListV(ln1).Print();
            Console.WriteLine("END => Insertion sort => Linked List ;");
			Console.WriteLine($"  ");
            #endregion

            #region Remove nth node from end of LL
            LinkedList reversLinkedListMtoN = new LinkedList();
            reversLinkedListMtoN.AddNode(new ListNode(1));
            reversLinkedListMtoN.AddNode(new ListNode(2));
            reversLinkedListMtoN.AddNode(new ListNode(3));
            reversLinkedListMtoN.AddNode(new ListNode(4));
            reversLinkedListMtoN.AddNode(new ListNode(5));
            reversLinkedListMtoN.AddNode(new ListNode(6));
            reversLinkedListMtoN.AddNode(new ListNode(7));
            reversLinkedListMtoN.AddNode(new ListNode(8));
            reversLinkedListMtoN.AddNode(new ListNode(9));
            int n = 8;
            sw.Start();
            Console.WriteLine($"Remove nth node from End 'n':{n}  in linkedlist {reversLinkedListMtoN.Head.Print()} - {RemoveNthFromEnd(reversLinkedListMtoN.Head, n)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
			Console.WriteLine($"  ");
            #endregion

            #region Reverse Linked List from node index 'm' to 'n'
            reversLinkedListMtoN = new LinkedList();
            reversLinkedListMtoN.AddNode(new ListNode(1));
            reversLinkedListMtoN.AddNode(new ListNode(2));
            reversLinkedListMtoN.AddNode(new ListNode(3));
            reversLinkedListMtoN.AddNode(new ListNode(4));
            reversLinkedListMtoN.AddNode(new ListNode(5));
            reversLinkedListMtoN.AddNode(new ListNode(6));
            reversLinkedListMtoN.AddNode(new ListNode(7));
            reversLinkedListMtoN.AddNode(new ListNode(8));
            reversLinkedListMtoN.AddNode(new ListNode(9));
            int k = 3;
            sw.Start();
            Console.WriteLine($"ReverseKGroup 'k':{k}  in linkedlist {reversLinkedListMtoN.Head.Print()} - {ReverseKGroup(reversLinkedListMtoN.Head, k)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");           
            sw.Reset();
			Console.WriteLine($"  ");
            #endregion

            #region Reverse Linked List from node index 'm' to 'n'
            reversLinkedListMtoN = new LinkedList();
            reversLinkedListMtoN.AddNode(new ListNode(1));
            reversLinkedListMtoN.AddNode(new ListNode(2));
            reversLinkedListMtoN.AddNode(new ListNode(3));
            reversLinkedListMtoN.AddNode(new ListNode(4));
            reversLinkedListMtoN.AddNode(new ListNode(5));
            reversLinkedListMtoN.AddNode(new ListNode(6));
            reversLinkedListMtoN.AddNode(new ListNode(7));
            reversLinkedListMtoN.AddNode(new ListNode(8));
            reversLinkedListMtoN.AddNode(new ListNode(9));
            int strtIndx = 2, endIndex = 4;
            sw.Start();
            Console.WriteLine($"Reverse Linked List from node index 'm':{strtIndx} to 'n':{endIndex}  in linkedlist {reversLinkedListMtoN.Head.Print()} - {ReverseBetweenMansN(reversLinkedListMtoN.Head, strtIndx, endIndex)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            //Console.WriteLine($"Reverse Linked List from node index 'm':{strtIndx} to 'n':{endIndex}  in linkedlist {reversLinkedListMtoN.Head.Print()} - {ReverseBetween(reversLinkedListMtoN.Head, strtIndx, endIndex)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
			Console.WriteLine($"  ");
            #endregion

            #region  Reverse first 'n' Nodes in Linked list
            LinkedList reversList = new LinkedList();
            reversList.AddNode(new ListNode(1));
            reversList.AddNode(new ListNode(2));
            reversList.AddNode(new ListNode(3));
            reversList.AddNode(new ListNode(4));
            reversList.AddNode(new ListNode(5));
            reversList.AddNode(new ListNode(6));
            reversList.AddNode(new ListNode(7));
            reversList.AddNode(new ListNode(8));
            reversList.AddNode(new ListNode(9));
            int firstKItems = 6;
            sw.Start();
            Console.WriteLine($"ReverseKGroup '{firstKItems}' in linkedlist {reversList.Head.Print()} - {ReverseFirstNumberOfNodes(reversList.Head, firstKItems)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
			Console.WriteLine($"  ");
            #endregion

            #region SwapPairs - Reverse two in seq
            reversList = new LinkedList();
            reversList.AddNode(new ListNode(1));
            reversList.AddNode(new ListNode(2));
            reversList.AddNode(new ListNode(3));
            reversList.AddNode(new ListNode(4));
            reversList.AddNode(new ListNode(5));
            reversList.AddNode(new ListNode(6));
            reversList.AddNode(new ListNode(7));
            reversList.AddNode(new ListNode(8));
            sw.Start();
            Console.WriteLine($"SwapPairs - Reverse two in seq linkedlist {reversList.Head.Print()} - {SwapPairs(reversList.Head)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
			Console.WriteLine($"  ");
            #endregion

            #region Reverse Linked List
            //reversList = new LinkedList();
            //reversList.AddNode(new ListNode(1));
            //reversList.AddNode(new ListNode(2));
            //reversList.AddNode(new ListNode(3));
            //reversList.AddNode(new ListNode(4));
            //reversList.AddNode(new ListNode(5));
            //reversList.AddNode(new ListNode(6));
            //reversList.AddNode(new ListNode(7));
            //reversList.AddNode(new ListNode(8));
            //sw.Start();
            //Console.WriteLine($"Reverse linkedlist Recursively {reversList.Head.Print()} - {LinkedListTests.RecursivelyReverseList(reversList.Head)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            //sw.Reset();
            reversList = new LinkedList();
            reversList.AddNode(new ListNode(1));
            reversList.AddNode(new ListNode(2));
            reversList.AddNode(new ListNode(3));
            reversList.AddNode(new ListNode(4));
            reversList.AddNode(new ListNode(5));
            reversList.AddNode(new ListNode(6));
            reversList.AddNode(new ListNode(7));
            reversList.AddNode(new ListNode(8));
            sw.Start();
            Console.WriteLine($"Reverse linkedlist Iteratively {reversList.Head.Print()} - {IterativelyReverseList(reversList.Head)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
			Console.WriteLine($"  ");
            #endregion

            #region Remove all value of Duplicates from Sorted List II
            LinkedList sortedLnkLst1 = new LinkedList();
            sortedLnkLst1.AddNode(new ListNode(2));
            sortedLnkLst1.AddNode(new ListNode(2));
            sortedLnkLst1.AddNode(new ListNode(2));
            sortedLnkLst1.AddNode(new ListNode(20));
            sortedLnkLst1.AddNode(new ListNode(21));
            sortedLnkLst1.AddNode(new ListNode(22));
            sortedLnkLst1.AddNode(new ListNode(22));
            sortedLnkLst1.AddNode(new ListNode(22));
            sortedLnkLst1.AddNode(new ListNode(23));
            sortedLnkLst1.AddNode(new ListNode(24));

            sw.Start();
            Console.WriteLine($"Remove Duplicates entries from sorted linkedlist - {DeleteDuplicates(sortedLnkLst1.Head)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");

            sw.Reset();
			Console.WriteLine($"  ");
            #endregion

            #region Remove all value of Duplicates from Sorted List II
            LinkedList sortedLnkLst = new LinkedList();
            sortedLnkLst.AddNode(new ListNode(2));
            sortedLnkLst.AddNode(new ListNode(2));
            sortedLnkLst.AddNode(new ListNode(2));
            sortedLnkLst.AddNode(new ListNode(20));
            sortedLnkLst.AddNode(new ListNode(21));
            sortedLnkLst.AddNode(new ListNode(22));
            sortedLnkLst.AddNode(new ListNode(22));
            sortedLnkLst.AddNode(new ListNode(22));
            sortedLnkLst.AddNode(new ListNode(23));
            sortedLnkLst.AddNode(new ListNode(24));

            sw.Start();
            Console.WriteLine($"Remove all values that have Duplicates from sorted linkedlist - {DeleteAllValueWithDuplicates(sortedLnkLst.Head)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
            sw.Reset();
			Console.WriteLine($"  ");
            #endregion

            #region Merge two sorted linked list
            for (int i = 0; i < 100; i++)
            {
                LinkedList llist1 = new LinkedList();
                LinkedList llist2 = new LinkedList();

                llist1.AddNode(new ListNode(5));
                llist1.AddNode(new ListNode(5));
                llist1.AddNode(new ListNode(10));
                llist1.AddNode(new ListNode(15));

                llist2.AddNode(new ListNode(2));
                llist2.AddNode(new ListNode(2));
                llist2.AddNode(new ListNode(3));
                llist2.AddNode(new ListNode(20));
                llist2.AddNode(new ListNode(21));
                llist2.AddNode(new ListNode(22));
                llist2.AddNode(new ListNode(23));

                sw.Start();
                Console.WriteLine($"MergeTwoLists - {MergeTwoSortedLinkedLists(llist1.Head, llist2.Head)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
                sw.Reset();

                sw.Start();
                Console.WriteLine($"MergeTwoSortedLinkedListUsePopAndPush using Recursion - {MergeTwoSortedLinkedListUsePopAndPush(llist1.Head, llist2.Head)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
                sw.Reset();
				//Console.WriteLine($"  ");

                LinkedList llist11 = new LinkedList();
                LinkedList llist22 = new LinkedList();

                llist11.AddNode(new ListNode(1));
                llist11.AddNode(new ListNode(2));
                llist11.AddNode(new ListNode(4));

                llist22.AddNode(new ListNode(1));
                llist22.AddNode(new ListNode(3));
                llist22.AddNode(new ListNode(4));
                sw.Start();
                Console.WriteLine($"MergeTwoSortedLinkedListUsePopAndPush using Recursion - {MergeTwoSortedLinkedListUsePopAndPush(llist11.Head, llist22.Head)?.Print()} - ({sw.ElapsedMilliseconds})ms - ({sw.ElapsedTicks})ticks");
                sw.Reset();
            }
            #endregion
     Console.WriteLine($"  ");
}

	#region Find Middle of Linked List
	private static ListNode FindMiddleOfLinkedList(ListNode head)
	{
		ListNode p1 = head;
		ListNode p2 = head;
		while(p1 != null && p1.next != null)
		{
			p1 = p1.next.next;
			p2 = p2.next;
		}
		return p2;
	}
	#endregion

        #region DetectCycle in circular LinkedList
        //Followinf Floys's Algorithm (Tortoice & Hair )
        private static ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null) return null;

            ListNode t = head, h = head;
            while(h != null && h.next != null && head.next.next != null)
            {
                t = t.next;
                h = h.next.next;
                if(t == h)
                {
                    t = head;
                    while(t != h)
                    {
                        t = t.next;
                        h = h.next;
                    }
                    return t;
                }
            }
            return null;
        }
        #endregion


        #region Merge Sort LinkedList // effecient way to sort LinkedList

        #endregion

        #region InsertSort Linked List
        public static ListNode InsertSortLinkedListV(ListNode head)
        {
            if (head == null) return null;

            ListNode dummy = new ListNode(0);
            ListNode cur = null;
            //cur is left sorted linked list and head is start of right side unsorted linked list
            //eg: 1->2->3->5 <-(9)     | 4->6->8->7
            while (head != null)
            {
                var temp = head.next;
                cur = dummy;
                while (cur.next != null && cur.next.val < head.val)
                {
                    cur = cur.next;
                }
                head.next = cur.next;
                cur.next = head;
                head = temp;
            }
            return dummy.next;
        }

        #endregion

        #region Remove nth node from end of LL
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null || head.next == null || n == 0) return head;
            int indx = 1;
            ListNode lstNode = head;
            ListNode nthNode = head, prev = head;

            while (indx <= n && lstNode != null)
            {
                indx++;
                lstNode = lstNode.next;             
            }           

            while (lstNode != null)
            {
                prev = nthNode;
                nthNode = nthNode.next;
                //move next
                lstNode = lstNode.next;
            }
            if (prev == nthNode)
            {
                head = nthNode.next;
            }
            else
            {
                prev.next = nthNode.next;
            }

            return head;
        }
        #endregion

        #region ReverseKGroup
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || head.next == null || k == 1) return head;

            ListNode root = null, prevEndN = null, cycStrtN = head;
            int indx = 0;
            while (head != null)
            {
                indx++;
                if (indx % k == 0)
                {
                    ListNode prev = cycStrtN;
                    ListNode nxt = head.next;
                    ListNode r = ReverseFirstNnodes(cycStrtN, k);                    
                    cycStrtN = nxt;
                    if (prevEndN != null)
                    {
                        prevEndN.next = r;
                        prevEndN = prev;
                    }
                    else prevEndN = prev;
                    
                    if (root == null)
                        root = r;
                    prev.next = nxt;
                    head = nxt;
                }
                else
                {
                    head = head.next;
                }
            }
            return root;
        }

        private static ListNode ReverseFirstNnodes(ListNode head, int count)
        {
            ListNode prev = null, root = head;
            int index = 0;
            while (head != null && head.next != null)
            {
                ListNode t, nxt;
                if (index + 2 <= count)
                {
                    index += 2;
                    nxt = head.next.next;
                    t = head.next;           // 1->2  | 3->4
                    t.next = head;          // 2-1   | 4->3
                    head.next = prev;
                    prev = t;

                    head = nxt;
                }
                else break;
            }
            if (index + 1 == count)
            {
                ListNode nxt = head.next;
                head.next = prev;
                prev = head;
                root.next = nxt;
            }
            root.next = null;
            return prev;
        }


        #endregion

        #region Reverse Linked List from node index 'm' to 'n'

        public static ListNode ReverseBetweenMansN(ListNode head, int m, int n)
        {
            if (head == null || head.next == null || m > n || n == m) return head;
            ListNode root = (m != 1) ? head : null;
            int indx = 0;
            ListNode prev = null;
            while (head != null)
            {
                indx++;
                if (indx == m)
                {
                    ListNode r = ReverseFirstN(head, (n - m) + 1);
                    if (prev != null)
                        prev.next = r;
                    else root = r;
                    break;
                }
                else
                {
                    prev = head;
                }
                head = head.next;
            }
            return root;
        }

        private static ListNode ReverseFirstN(ListNode head, int count)
        {
            ListNode prev = null, root = head;
            int index = 0;
            while (head != null && head.next != null)
            {
                ListNode t, nxt;
                if (index + 2 <= count)
                {
                    index += 2;
                    nxt = head.next.next;
                    t = head.next;           // 1->2  | 3->4
                    t.next = head;          // 2-1   | 4->3
                    head.next = prev;
                    prev = t;

                    head = nxt;
                }
                else break;
            }
            if (index + 1 == count)
            {
                ListNode nxt = head.next;
                head.next = prev;
                prev = head;
                root.next = nxt;
            }
            else if (head != null)
            {
                root.next = head;
            }
            return prev;
        }


        public static ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null || head.next == null || m == n || m > n) return head;         

            ListNode root = head;
            ListNode prevRevEnd = null;     //  Start node after reverse - 'n' node on incoming LL
            ListNode mThNode = null;        //  End node after reverse - 'm' node on incoming LL
            ListNode prevEndB4RevN = null;  // end node befre - reverse start node
            int i = 0;

            while (head != null && head.next != null)
            {
                ListNode nxtN = head.next;
                i++;
                if (i >= m && i <= n) //start node for reverse
                {
                    if (mThNode == null) mThNode = head;
                    nxtN = head.next.next;
                    i++;

                    //swap ; t is head of reverse
                    ListNode t = head.next; // 1->2 | 3->4
                    t.next = head;          // 2->1 | 4->3
                    head.next = prevRevEnd; // 4->3=>2->1
                    prevRevEnd = t;
                    if (i == n)
                    {
                        if (prevEndB4RevN != null) prevEndB4RevN.next = t;
                        mThNode.next = nxtN;
                        break;
                    }
                    else if (i + 1 == n)
                    {
                        head = nxtN;
                        nxtN = nxtN.next;
                        head.next = prevRevEnd;
                        if (prevEndB4RevN != null) prevEndB4RevN.next = head;
                        prevRevEnd = head;
                        mThNode.next = nxtN;                        
                        i++;
                        break;
                    }
                }
                else // if (i > m && i == n) //end of reverse node in LL
                {
                    prevEndB4RevN = head;
                }
                //set head to nxt Node to continue loop
                head = nxtN;
            }
            if (m == 1)
            {
                root = prevRevEnd;
            }
            return root;
        }
        #endregion

        #region Reverse first 'n' Nodes in Linked list
        public static ListNode ReverseFirstNumberOfNodes(ListNode head, int k)
        {
            if (head == null || head.next == null) return head;
            if (k <= 1) return head;

            ListNode firstNodeRef = head;
            ListNode prevEndN = null;
            while (k > 0 && head != null && head.next != null)
            {
                k = k - 2;
                ListNode temp = head.next.next;
                //swap
                ListNode x = head.next; // 1->2 | 3->4
                x.next = head;          // 2->1 | 4->3            
                // set previous end to new ext
                head.next = prevEndN;
                //reset previous end node to latest reversed seq
                prevEndN = x;
                if (k == 1)
                {
                    x = temp.next;
                    temp.next = prevEndN;
                    prevEndN = temp;
                    temp = x;
                    k--;
                }
                //set head to next start node & continue loop
                head = temp;
            }
            if (k == 0 && head != null)
            {
                firstNodeRef.next = head;
            }
            return prevEndN;
        }
        #endregion

        #region SwapPairs - Reverse two in seq
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode root = head.next;
            ListNode nEnd = null;
            while (head != null && head.next != null)
            {
                //hold start node of next pair 
                ListNode temp = head.next.next; //1->2->3 or 3->4->5 or 5->6->null
                //swap
                ListNode x = head.next;    // 1->2   or 3->4
                x.next = head;             // 2->1   or 4->3

                if (nEnd != null) nEnd.next = x;
                nEnd = x.next;

                //return next pair to swap
                head = temp;
            }
            nEnd.next = (head != null) ? head : null;
            return root;
        }
        #endregion

        #region Reverse Linked List
        public static ListNode RecursivelyReverseList(ListNode head)
        {
            return null;
        }

        public static ListNode IterativelyReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode previousEnd = null;
            while (head != null && head.next != null)
            {
                ListNode nxtLLStrt = head.next.next;
                //swap
                ListNode t = head.next; // 1->2  | 3->4
                t.next = head;          // 2->1  | 4->3

                //set prev LL start to end of swapped
                head.next = previousEnd;

                //reset previous node start 
                previousEnd = t;

                //return next LL starting point to loop
                head = nxtLLStrt;
            }
            if (head != null)
            {
                head.next = previousEnd;
                previousEnd = head;
            }
            return previousEnd;
        }

        #endregion

        #region MergeTwoSortedLinkedLists
        public static ListNode MergeTwoSortedLinkedLists(ListNode l1, ListNode l2)
        {
            LinkedList linkedList = new LinkedList();
            ListNode leftNode = l1;
            ListNode rightNode = l2;

            while (true)
            {
                if (leftNode == null && rightNode == null)
                {
                    break;
                }
                else if (leftNode != null && rightNode != null)
                {
                    if (leftNode.val < rightNode.val)
                    {
                        linkedList.AddNode(new ListNode(leftNode.val));
                        leftNode = leftNode.next;
                    }
                    else if (leftNode.val > rightNode.val)
                    {
                        linkedList.AddNode(new ListNode(rightNode.val));
                        rightNode = rightNode.next;
                    }
                    else
                    {
                        linkedList.AddNode(new ListNode(leftNode.val));
                        linkedList.AddNode(new ListNode(rightNode.val));
                        leftNode = leftNode.next;
                        rightNode = rightNode.next;
                    }
                }
                else if (leftNode != null && rightNode == null)
                {
                    linkedList.AddNode(leftNode);
                    break;
                }
                else if (leftNode == null && rightNode != null)
                {
                    linkedList.AddNode(rightNode);
                    break;
                }
            }

            return linkedList.Head;
        }

        public static ListNode MergeTwoSortedLinkedListUsePopAndPush(ListNode leftNode, ListNode rightNode)
        {
            ListNode head = null;
            if (leftNode == null && rightNode == null)
            {
                return null;
            }
            else if (leftNode != null && rightNode == null)
            {
                head = leftNode;
            }
            else if (leftNode == null && rightNode != null)
            {
                head = rightNode;
            }
            else if (leftNode != null && rightNode != null)
            {
                if (leftNode.val < rightNode.val)
                {
                    head = leftNode;
                    head.next = MergeTwoSortedLinkedListUsePopAndPush(leftNode.next, rightNode);
                }
                else if (leftNode.val > rightNode.val)
                {
                    head = rightNode;
                    head.next = MergeTwoSortedLinkedListUsePopAndPush(leftNode, rightNode.next);
                }
                else
                {
                    head = leftNode;
                    ListNode temp = rightNode;
                    temp.next = MergeTwoSortedLinkedListUsePopAndPush(leftNode.next, rightNode.next);
                    head.next = temp;
                }
            }
            return head;
        }
        #endregion

        #region Remove all value of Duplicates from Sorted List II
        public static ListNode DeleteAllValueWithDuplicates(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            if (head == null) return null;
            if (head.next == null) return head;
            if (head.val < head.next.val)
            {
                head.next = DeleteAllValueWithDuplicates(head.next);
                return head;
            }
            else // equals
            {
                ListNode tempNode = head.next.next;
                while (tempNode != null && head.next.val == tempNode.val)
                {
                    tempNode = tempNode.next;
                }
                return DeleteAllValueWithDuplicates(tempNode);
            }
        }
        #endregion

        #region Delete Duplicate node from sorted list
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            if (head.val < head.next.val)
            {
                head.next = DeleteDuplicates(head.next);
                return head;
            }
            else
            {
                ListNode temp = head.next.next;
                while (temp != null && head.val == temp.val)
                {
                    temp = temp.next;
                }
                head.next = DeleteDuplicates(temp);
                return head;
            }
        }
        #endregion
  


    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }
        public ListNode(int v)
        {
            val = v;
        }
        public object Print()
        {
            ListNode temp = this;
            while (temp != null)
            {
                Console.Write($"{temp.val}->");
                temp = temp.next;

            }
            Console.Write($"null");
            Console.WriteLine($"");
            return null;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder(val.ToString()+" ; ");
            ListNode temp = this;
            while (temp != null)
            {
               s.Append($"{temp.val}->");
                temp = temp.next;

            }
            s.Append($"null");
            s.AppendLine($"");
            return s.ToString();
        }
    }
    public class LinkedList
    {
        public LinkedList()
        {

        }
        public ListNode Head { get; private set; }
        public ListNode Tail { get; private set; }

        public bool AddNode(ListNode node)
        {
            if (node == null) return false;

            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = GetTailNode(node);
            }
            else if (Tail == null)
            {
                Head.next = node;
                Tail = GetTailNode(node);
            }
            else
            {
                Tail.next = node;
                Tail = GetTailNode(node);
            }
            return true;
        }

        private ListNode GetTailNode(ListNode newNode)
        {
            ListNode temp = newNode;
            while (temp?.next != null)
                temp = temp.next;
            return temp;
        }
    }