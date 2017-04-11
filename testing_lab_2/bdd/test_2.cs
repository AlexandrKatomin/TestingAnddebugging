using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testing_lab_2;

namespace bdd
{
    [Binding]
    public class test_2
    {

        BinaryTree<string> tree = new BinaryTree<string>();

        [When(@"I add second element with smalest key")]
        public void WhenIAddSecondElementWithSmalestKey()
        {
            tree.Add(10, "bus");
            tree.Add(2, "pen");
        }
        
        [Then(@"the second right  element is added to tree")]
        public void ThenTheSecondRightElementIsAddedToTree()
        {
            Assert.AreEqual("pen", tree.Left.Data);
        }
    }
}
