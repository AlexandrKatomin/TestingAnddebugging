using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab_2 {
    public class BinaryTree<T> {

        public T Data { get; set; }
        public int? Key { get; set; }
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; }
        public BinaryTree<T> Parent { get; set; }

        public void Add(int key, T data) {
            if (Key == null || Key == key) {
                Data = data;
                Key = key;
                return;
            }
            if (key < Key) {
                Left = createNewChildIfHeIsNull(Left, this);
                Left.Add(key, data);
            } else {
                Right = createNewChildIfHeIsNull(Right, this);
                Right.Add(key, data);
            }
        }
        public BinaryTree<T> createNewChildIfHeIsNull(BinaryTree<T> child, BinaryTree<T> parent) {
            if (child == null) {
                BinaryTree<T> newChild = new BinaryTree<T>();
                newChild.Parent = parent;
                return newChild;
            }
            return child;
        }

        public BinaryTree<T> Find(int key) {
            if (Key == null) return null;
            if (Key == key) return this;
            if (key < Key && Left != null) {
                return Left.Find(key);
            } else if (Right != null) {
                return Right.Find(key);
            } else return null;
        }

        public static BinaryTree<T> Minimum(BinaryTree<T> node) {
            if (node.Left == null) return node;
            return Minimum(node.Left);
        }

        public static  BinaryTree<T> Remove(BinaryTree<T> root, int key) {
            if (root == null) return null;
            if (key < root.Key) {
                root.Left = Remove(root.Left, key);
            }
            if (key > root.Key) {
                root.Right = Remove(root.Right, key);
            } else if (root.Left != null && root.Right != null) {
                BinaryTree<T> min = Minimum(root.Right);
                root.Key = min.Key;
                root.Data = min.Data;
                root.Right = Remove(root.Right, (int)root.Key);
            } else if (root.Left != null) {
                root = root.Left;
            } else {
                root = root.Right;
            }
            return root;
        }
    }
}
