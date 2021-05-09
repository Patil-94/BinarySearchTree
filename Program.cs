using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------Welcome To Binary Search Tree--------");
            Console.WriteLine();
            BST<int> bST = new BST<int>(56);
            bST.Insert(30);
            bST.Insert(70);
            bST.Display(); 
                                          //    56
                                       // 30         70
        
            Console.Read();
        }
    }
}
