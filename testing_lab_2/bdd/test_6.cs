using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testing_lab_2;

namespace bdd
{
    [Binding]
    public class test_6
    {
        BinaryTree<string> tree = new BinaryTree<string>();
    
        [When(@"I remove node with right son")]
        public void WhenIRemoveNodeWithRightSon()
        {
            tree.Add(5, "Иванов");
            tree.Add(7, "Петров");
            tree = BinaryTree<string>.Remove(tree, 5);
        }
        
        [Then(@"node is removed and right son will replace he")]
        public void ThenNodeIsRemovedAndRightSonWillReplaceHe()
        {
            Assert.AreEqual(tree.Data, "Петров");
            Assert.AreEqual(tree.Right, null);
        }
    }
}
