using System;

public class KthSmallestEleInBST
{
    public class TreeNode
    {
      public int val;
      public TreeNode left;
         public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
 
    }
    public static int KthSmallest(TreeNode root, int k)
    {

        Stack<TreeNode> st = new Stack<TreeNode>();

        TraverseLeft(st, root);
        while (--k > 0)
        {
            TraverseLeft(st, st.Pop().right);

        }
        return st.Pop().val;
    }

    void TraverseLeft(Stack<TreeNode> st, TreeNode root)
    {
        while (root != null)
        {
            st.Push(root);
            root = root.left;
        }
    }
}
