using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItrerativeInorderTraversalBinaryTree
{
    class IterativeInOrderTeravelsal
    {
        public List<int> IterativeInorder(Node root)
        {
            List<int> li = new List<int>();
            if (root == null)
                return li;

            Stack<Node> S = new Stack<Node>();

            while (true)
            {
                if(root != null)
                {
                    S.Push(root);
                    root = root.left;
                }
                else
                {
                    if (S.Count == 0)
                        break;

                    root = S.Pop();
                    li.Add(root.data);
                    root = root.right;
                }
            }
            return li;
        }
    }
}
