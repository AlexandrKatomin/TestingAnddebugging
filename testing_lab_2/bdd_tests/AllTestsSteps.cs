using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using testing_lab_2;

namespace bdd_tests
{
    [Binding]
    public class AllTestsSteps
    {
        BinaryTree<string> tree = new BinaryTree<string>();
        [When(@"I add new element")]
        public void WhenIAddNewElement()
        {
            tree.Add(1,"ss");
        }
        
        [Then(@"the first element is added to tree")]
        public void ThenTheFirstElementIsAddedToTree()
        {
            //Assert.AreEqual();
        }
    }
}
