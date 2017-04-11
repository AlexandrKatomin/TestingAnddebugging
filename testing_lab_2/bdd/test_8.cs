using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testing_lab_2;

namespace bdd
{
    [Binding]
    public class test_8
    {
        BinaryTree<string> tree = new BinaryTree<string>();
        
           
        [When(@"I remove node with two sons")]
        public void WhenIRemoveNodeWithTwoSons()
        {
            tree.Add(5, "Иванов");
            tree.Add(3, "Петров");
            tree.Add(10, "Смит");
            tree.Add(7, "Спилберг");
            tree.Add(11, "Сидоров");
            tree = BinaryTree<string>.Remove(tree, 5);
        }
        
        [Then(@"node is removed and minimal element from right branch will replace he")]
        public void ThenNodeIsRemovedAndMinimalElementFromRightBranchWillReplaceHe()
        {
            Assert.AreEqual("Спилберг", tree.Data);
            Assert.AreEqual(7, tree.Key);
        }
    }
}
