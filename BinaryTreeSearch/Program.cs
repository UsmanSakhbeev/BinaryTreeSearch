using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(6);
            tree.Add(4);
            tree.Add(13);
            Console.WriteLine(tree.nodeCount);
            Console.ReadLine();
        }
    }
}
