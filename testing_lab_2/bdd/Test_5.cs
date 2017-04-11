using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using testing_lab_2;

namespace bdd
{
    [Binding]
    public class Test_5
    {

        BinaryTree<string> tree = new BinaryTree<string>();

        [When(@"I add  elemem duplicate whith duplicate key")]
        public void WhenIAddElememDuplicateWhithDuplicateKey()
        {
            tree.Add(10, "bus");
            tree.Add(10, "pen");
        }
        
        [Then(@"the new element")]
        public void ThenTheNewElement()
        {
            Assert.AreEqual("pen", tree.Data);
        }
    }
}
