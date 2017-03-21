using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab_2 {
    class Program {
      
        static void Main(string[] args) {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Add(5, "Иванов");
            tree.Add(8, "Сидоров");
            BinaryTree<string> t2 = tree.Find(8);
            int r = 4;




        }
    }
}
