using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using testing_lab_2;

namespace testing_lab_2.TDD {
    [TestClass]
    public class TestOfBinaryTree {
        [TestMethod]
        public void CreateTree() {
            BinaryTree tree = new BinaryTree();
        }

        [TestMethod]
        public void InsertElement() {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
        }
    }
}
