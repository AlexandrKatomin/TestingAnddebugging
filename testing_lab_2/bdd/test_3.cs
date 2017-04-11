using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testing_lab_2;

namespace bdd
{
    [Binding]
    public class test_3
    {

        BinaryTree<string> tree = new BinaryTree<string>();
        [When(@"I add second element with larger key")]
        public void WhenIAddSecondElementWithLargerKey()
        {
            tree.Add(10, "bus");
            tree.Add(12, "pen");
        }
        
        [Then(@"the second element is added to tree")]
        public void ThenTheSecondElementIsAddedToTree()
        {
            Assert.AreEqual("pen", tree.Right.Data);
        }
    }
}
