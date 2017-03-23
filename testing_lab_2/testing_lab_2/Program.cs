using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab_2 {
    class Program {
      
        static void Main(string[] args) {
             BinaryTree< string > tree = new BinaryTree<string>();
            tree.Add(5, "Иванов");
            tree.Add(7, "Петров");
            tree = BinaryTree<string>.Remove(tree, 5);
            int r = 4;




        }
    }
}
