using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using testing_lab_2;

namespace testing_lab_2.TDD {
    [TestClass]
    public class TestOfBinaryTree {
        [TestMethod]
        public void CreateTree() {
            BinaryTree<string> tree = new BinaryTree<string>();
            
            // Assert.IsInstanceOfType(tmp, int);  ? ошибка не компилируется
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
            tree.Add(4,"Петров");
           Assert.AreEqual(tree.Data, "Иванов");
            Assert.AreEqual(tree.Right.Data, "Сидоров");
           Assert.AreEqual(tree.Left.Data, "Петров");
        }
        [TestMethod]
        public void InsertduplacatKey() {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Add(5, "Иванов");
            tree.Add(5, "Смит");
            Assert.AreEqual("Смит",tree.Data);
         
        }
        [TestMethod]
        public void TestFind() {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Add(5, "Иванов");
            tree.Add(8, "Сидоров");
            tree.Add(7, "Петров");
             BinaryTree<string> t2 = tree.Find(7);
              Assert.AreEqual("Петров",t2.Data);
        }
        [TestMethod]
        public void TestFindOFUnavailableEl() {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Add(5, "Иванов");
            BinaryTree<string> t2 = tree.Find(7);
            //Assert.AreEqual(null, t2.Data);
        }

        [TestMethod]
        public void TestRemove() {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Add(5, "Иванов");
            tree.Add(7, "Петров");
            tree=BinaryTree<string>.Remove(tree,7);
            Assert.AreEqual(null,tree.Right);
        }
        [TestMethod]
        public void TestRemoveRoot() {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Add(5, "Иванов");
            tree = BinaryTree<string>.Remove(tree, 5);
            Assert.AreEqual(null,tree);
        }

    }
}
