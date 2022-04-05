using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    public class Node<TKey> where TKey : IComparable<TKey>
    {
        public TKey Key { get;}
        public Node<TKey> left;
        public Node<TKey> right; 

        public Node(TKey key)
        {
            Key = key;
        }
    }
}
