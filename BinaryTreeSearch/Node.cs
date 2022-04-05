using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    public class Node<TKey, TValue> where TKey : IComparable<TKey>
    {
        public TKey Key { get;}
        public TValue Value { get;}

        public Node<TKey, TValue> left;
        public Node<TKey, TValue> right;

        public Node(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
