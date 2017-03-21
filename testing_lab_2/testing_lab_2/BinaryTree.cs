using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab_2 {
    public class BinaryTree<T> {
        public enum TypesOfNode {
            Left,
            Right 
        }
        //  public int? Data { get; set; }
       
        public T Data { get; set; }
        public int? Key { get; set; }
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; }

        internal BinaryTree<string> Remove(int v) {
            throw new NotImplementedException();
        }

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
            if (key < Key) {
                return Left.Find(key);
            } else {
                return Right.Find(key);
            }
        }


        TypesOfNode? FindingTypeOfNode(BinaryTree<T> node) {
            if (node.Parent == null) return null;
            if (node.Parent.Left == node) {
                return TypesOfNode.Left;
            } else {
                return TypesOfNode.Right;
            }
        }

      //  public static BinaryTree<T> Remove(BinaryTree<T> tree,int key) {
        //    return Remove(tree,key);
           
        //}
        private void AppropriationParentOfNodeOfNewChild(TypesOfNode? typeNode, BinaryTree<T> node, BinaryTree<T> newChid) {
            if (typeNode == TypesOfNode.Left) {
                node.Parent.Left = newChid;
            }
            if (typeNode == TypesOfNode.Right) {
                node.Parent.Right = newChid;
            }
            newChid.Parent = node.Parent;
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
              //  TypesOfNode? typeNode = FindingTypeOfNode(root);
               // AppropriationParentOfNodeOfNewChild(typeNode, root, root.Left);
                root = root.Left;
                //ссылка на перент
            } else {
              //  TypesOfNode? typeNode = FindingTypeOfNode(root);
               // AppropriationParentOfNodeOfNewChild(typeNode, root, root.Right);
              
                root = root.Right;
                //ссылка на перент
            }
            return root;

         
        }

    }
}
