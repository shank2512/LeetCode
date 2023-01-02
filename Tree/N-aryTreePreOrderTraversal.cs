/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}

*/

/* Intuition
Basics - 
 PreOrder - (root,left,right)
 InOrder  - (left,root,right)
 PostOrder - (left,right,root)

We will simply do a recursion call by creating a function named as PreOrder Traversal
Each Tree Node Type has value and list of its children from left to right
So first we will add that root value into the list and then run a loop over its children.
For each child call the same function again until it has no children.

We are adding the root value before doing a for loop since we need to do PreOrder Traversal.
*/
public class Solution {
    public IList<int> Preorder(Node root) {
        var list=new List<int>();
        PreOrderTraversal(list,root);
        return list;
    }

    public void PreOrderTraversal(List<int> list,Node root){
        if(root==null)
            return;
        
        list.Add(root.val);
        
        foreach(var node in root.children){
            PreOrderTraversal(list,node);
        }
    }
}