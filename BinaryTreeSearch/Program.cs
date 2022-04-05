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
            var tree = new Tree<int, string>();
            tree.Add(5, "asdf");
            tree.Add(6, "asqwef");
            tree.Add(4, null);
            tree.Add(13, "rqw");
            tree.Add(1, null);
            Console.WriteLine(tree.nodeCount);
            Console.ReadLine();
        }
    }
}
