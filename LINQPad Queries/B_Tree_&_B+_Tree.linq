<Query Kind="Program" />

void Main()
{
	
}

// You can define other methods, fields, classes and namespaces here

// B-Tree

// Understanding Diskstructure 
// - Track (one circle in the disk - O )
// - Sectore (slice of the disk - /_\ )
// - Block (track,sector) Row in sector

// Diskstructure (Disk) - Structuring, storing and managing data in Disk is called DBMS (Database Management System)
// Datastructure (RAM)  - Structuring and managing data in RAM is datastructure 

// Indexing - storing pointer to records in seperate block 
// - Densed Index - storing pointer to each record of a table
// - Sparse Index - Storeing Pointer to rack block (range in dense index) of the disk 

// M-Way Search Tree
// m-1 Keys
// M children 

// B-Tree - balanced tree - Degree of M 
// - M-1 Keys
// - at the most M children
// - root should have atleast two nodes 
// - Every non-leafe node (except root) has at least [m/2] children. 
// - insertion is bottom up , fill child first and split if child exceeds 'n' & create parent node
// - Each key have pointer to its value in disk


// B+ Tree
// - Same as above B-Tree
// - only leaf nodes have pointer to each key
// - parent key node will not have pointers to actual record 
// - every parent key will be present in the leaf node with pointer to actual record
// - All leaf nodes are linked-list in nature , each entry/key in leaf node have pointer to actual record

// Balanced - Binary Search Tree (BST)
// - left child node is smaller than parent node 
// - Right Node is greater to parent tree 
// - every insert and delete will auto balance the tree (Selfe Balanced Trees)
// - search/insert/delete time complexity on balanced binary search tree is O(log(n)) //  on un-balanced BST is O(n).
// 

public class Node
{
	public int Key { get; set; }
	public Node Left { get; set; }
}

public class BTree
{
	readonly Node[] nodes;
	readonly int n;
	
	public BTree(int m)
	{
		n = m;
		nodes = new Node[m-1];
	}
}

