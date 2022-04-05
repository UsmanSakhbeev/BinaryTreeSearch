using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    public class Tree<TKey, TValue> where TKey : IComparable<TKey>
    {
        private Node<TKey, TValue> root;
        public int nodeCount;
        
        public void Add(TKey key, TValue value)
        {
            var node = new Node<TKey, TValue>(key, value);
            if (root == null)
            {
                root = node;
                nodeCount = 1;
                return;
            }

            Add(node, root);
        }
        private void Add(Node<TKey, TValue> node,Node<TKey, TValue> current)
        {
            var compare = node.Key.CompareTo(current.Key);
            if (compare == 0)
                throw new ArgumentException("Element with this key is already exist");

            if(compare < 0)
            {
                if (current.left == null)
                {
                    current.left = node;
                    nodeCount++;
                    return;
                }
                else 
                {                    
                    Add(node, current.left);
                }                  
            }
            else if(compare >0)
            {
                if(current.right == null)
                {
                    current.right = node;
                    nodeCount++;
                    return;
                }
                else if(current.right != null)
                {                    
                    Add(node, current.right);
                }
            }
        }
    }
}
