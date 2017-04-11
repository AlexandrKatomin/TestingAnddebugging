using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testing_lab_2;

namespace bdd
{
    [Binding]
    public class test_7
    {

        BinaryTree<string> tree = new BinaryTree<string>(); 
        [When(@"I remove node with lef son")]
        public void WhenIRemoveNodeWithLefSon()
        {
            tree.Add(5, "Иванов");
            tree.Add(3, "Петров");
            tree = BinaryTree<string>.Remove(tree, 5);
        }
        
        [Then(@"node is removed and left son will replace he")]
        public void ThenNodeIsRemovedAndLeftSonWillReplaceHe()
        {
            Assert.AreEqual(tree.Left, null);
            Assert.AreEqual(tree.Data, "Петров");
        }
    }
}
