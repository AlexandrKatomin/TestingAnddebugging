using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab_2 {
    public class BinaryTree {
        public int? Data { get; set; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }
        public BinaryTree Parent { get; set; }


        public void Add(int data) {
            if(Data ==null || Data ==data) {
                Data = data;
                return;
            }
            if (data < Data) {
                if (Left == null) {
                    Left = new BinaryTree();
                    Left.Parent = this;
                }
                Left.Add(data);
            }else {
                if (Right == null) {
                    Right = new BinaryTree();
                    Right.Parent = this;
                }
                Right.Add(data);
            }


        }
    }
}
