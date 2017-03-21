using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using testing_lab_2;

namespace testing_lab_2.TDD {
    [TestClass]
    public class TestOfBinaryTree {
        [TestMethod]
        public void CreateTree() {
            BinaryTree<string> tree = new BinaryTree<string>();
            //Assert.IsInstanceOfType(tree, BinaryTree);  ? ошибка не компилируется
        }

        [TestMethod]
        public void InsertElement() {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Add(5,"Иванов");
            Assert.AreEqual(tree.Data, "Иванов");
        }
        [TestMethod]
        public void InsertTwoElement() {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Add(5,"Иванов");
            tree.Add(8,"Сидоров");
            Assert.AreEqual(tree.Data, "Иванов");
            Assert.AreEqual(tree.Right.Data,"Сидоров");
        }
        [TestMethod]
        public void InsertThreeElement() {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Add(5, "Иванов");
            tree.Add(8, "Сидоров");
            tree.Add(7,"Петров");
           Assert.AreEqual(tree.Data, "Иванов");
            Assert.AreEqual(tree.Right.Data, "Сидоров");
           Assert.AreEqual(tree.Right.Left.Data, "Петров");
        }
       [TestMethod]
        public void TestFind() {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Add(5, "Иванов");
            tree.Add(8, "Сидоров");
            tree.Add(7, "Петров");
             BinaryTree<string> t2 = tree.Find(7);

              Assert.AreEqual(t2.Data, "Петров");
          
        }

    }
}
