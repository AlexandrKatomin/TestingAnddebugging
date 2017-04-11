using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testing_lab_2;

namespace bdd
{
    [Binding]
    public class test_9
    {
        BinaryTree<string> tree = new BinaryTree<string>();
        BinaryTree<string> t2;
       [When(@"I find element and element exist")]
        public void WhenIFindElementAndElementExist()
        {
            tree.Add(5, "Иванов");
            tree.Add(8, "Сидоров");
            tree.Add(7, "Петров");
            t2 = tree.Find(7);
        }
        
        [Then(@"return finding element")]
        public void ThenReturnFindingElement()
        {
            Assert.AreEqual("Петров", t2.Data);
        }
    }
}
