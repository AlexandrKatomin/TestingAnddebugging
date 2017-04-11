using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testing_lab_2;

namespace bdd
{
    [Binding]
    public class test_4
    {
        BinaryTree<string> tree = new BinaryTree<string>();
        
        [When(@"I remove element withouts sons")]
        public void WhenIRemoveElementWithoutsSons()
        {
            tree.Add(5, "Иванов");
            tree.Add(7, "Петров");
            tree = BinaryTree<string>.Remove(tree, 7);
        }
        
        [Then(@"tree will be empty")]
        public void ThenNodeWillBeEmpty()
        {
            Assert.AreEqual(null, tree.Right);
        }
    }
}
