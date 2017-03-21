using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab_2 {
    public class BinaryTree<T> {
      //  public int? Data { get; set; }
        public T Data { get; set; }
        public int? Key { get; set; }
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; }
        public BinaryTree<T> Parent { get; set; }


        /*
        public void Add(int data) {
            if(Data ==null || Data ==data) {
                Data = data;
                return;
            }
            if (data < Data) {
                Left=createNewChildIfHeIsNull(Left, this);
                Left.Add(data);
            }else {
                Right=createNewChildIfHeIsNull( Right, this);
                Right.Add(data);
            }
        }
        */
        public void Add(int key,T data) {
            if (Key == null || Key==key) {
                Data = data;
                Key = key;
                return;
            }
            if (key < Key) {
                Left = createNewChildIfHeIsNull(Left, this);
                Left.Add(key,data);
            } else {
                Right = createNewChildIfHeIsNull(Right, this);
                Right.Add(key,data);
            }
        }
        public BinaryTree<T> createNewChildIfHeIsNull( BinaryTree<T>  child,BinaryTree<T> parent) {
            if (child == null) {
                BinaryTree<T> newChild = new BinaryTree<T>();
                newChild.Parent = parent;
                return newChild;
            }
            return child;
        }

        public BinaryTree<T> Find (int key) {
            if (Key == null) return null;
            if (Key == key) return this;
            if (key < Key) {
                return Left.Find(key);
            }else {
                return Right.Find(key);
            }
        }


    }
}
