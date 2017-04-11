using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testing_lab_2;

namespace bdd
{
    [Binding]
    public class test_10
    {
        BinaryTree<string> tree = new BinaryTree<string>();
        BinaryTree<string> t2;
        [When(@"I find element and element not exist")]
        public void WhenIFindElementAndElementNotExist()
        {
            tree.Add(5, "Иванов");
            t2 = tree.Find(7);
        }
        
        [Then(@"return null")]
        public void ThenReturnNull()
        {
            Assert.AreEqual(null, t2);
        }
    }
}
