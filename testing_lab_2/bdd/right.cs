using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testing_lab_2;

namespace bdd
{
    
    [Binding]
    public class Test2
    {
       // BinaryTree<string> tree = new BinaryTree<string>();
        [When(@"I add second element with smalest key")]
        public void WhenIAddSecondElementWithSmalestKey()
        {
            //tree.Add(10, "bus");
           // tree.Add(5, "pen");
        }
        
        [Then(@"the second element is added to tree")]
        public void ThenTheSecondElementIsAddedToTree()
        {
           // Assert.AreEqual("pen", tree.Left.Data);
        }
    }
    
}
