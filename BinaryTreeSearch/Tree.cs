using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    public class Tree<TKey> where TKey : IComparable<TKey>
    {
        private Node<TKey> root;
        public int nodeCount;
        
        public void Add(TKey key)
        {
            if (root == null)
            {
                root = new Node<TKey>(key);
                nodeCount = 1;
                return;
            }

            Add(key, root);
        }
        private void Add(TKey key, Node<TKey> current)
        {
            var compare = key.CompareTo(current.Key);
            if (compare == 0)
                throw new ArgumentException("Element with this key is already exist");

            if(compare < 0)
            {
                if (current.left == null)
                {
                    current.left = new Node<TKey>(key);
                    nodeCount++;
                    return;
                }
                else 
                {                    
                    Add(key, current.left);
                }                  
            }
            else if(compare >0)
            {
                if(current.right == null)
                {
                    current.right = new Node<TKey>(key);
                    nodeCount++;
                    return;
                }
                else if(current.right != null)
                {                    
                    Add(key, current.right);
                }
            }
        }
    }
}
