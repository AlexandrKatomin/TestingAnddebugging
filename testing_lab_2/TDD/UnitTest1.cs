using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using testing_lab_2;

namespace testing_lab_2.TDD {
    [TestClass]
    public class TestOfBinaryTree {
        [TestMethod]
        public void CreateTree() {
            BinaryTree tree = new BinaryTree();
            //Assert.IsInstanceOfType(tree, BinaryTree);  ? ошибка не компилируется
        }

        [TestMethod]
        public void InsertElement() {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            Assert.AreEqual(tree.Data, 5);
        }
        public void InsertTwoElement() {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            tree.Add(8);
            Assert.AreEqual(tree.Data, 5);
            Assert.AreEqual(tree.Right.Data, 8);
        }
        public void InsertThreeElement() {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            tree.Add(8);
            tree.Add(7);
            Assert.AreEqual(tree.Data, 5);
            Assert.AreEqual(tree.Right.Data, 8);
            Assert.AreEqual(tree.Right.Left.Data, 8);
        }
    }
}
