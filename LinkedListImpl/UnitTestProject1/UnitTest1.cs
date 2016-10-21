using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Epam.Collectcions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLengthAndAdd()
        {
            LinkedList list = new LinkedList {12, "string", true};

            Assert.AreEqual(3, list.Length);
        }

        [TestMethod]
        public void TestAddAtFirstPosition()
        {
            LinkedList list = new LinkedList {12, 11, 10};
            list.AddAt(4, 0);
            Assert.AreEqual(4, list.ElementAt(0));
        }

        [TestMethod]
        public void TestAddAtLastPosition()
        {
            LinkedList list = new LinkedList {12, 11, 10};
            list.AddAt(4, 2);

            Assert.AreEqual(4, list.ElementAt(2));
        }
        [TestMethod]
        public void TestAddAtTheMiddle()
        {
            LinkedList list = new LinkedList {12, 11, 10};
            list.AddAt(4, 1);
            Assert.AreEqual(4, list.ElementAt(1));
        }

        [TestMethod]
        public void TestRemoveFromTheEnd()
        {
            LinkedList list = new LinkedList {12, 11, 10};
            list.Remove();
    
            Assert.AreEqual(2, list.Length);
            Assert.AreEqual(11, list.ElementAt(1));
        }

        [TestMethod]
        public void TestRemoveFromTheEndIfOnlyOneElementPresent()
        {
            LinkedList list = new LinkedList {12};
            list.Remove();

            Assert.AreEqual(0, list.Length);
        }

        [TestMethod]
        public void TestRemoveFromTheBeginning()
        {
            LinkedList list = new LinkedList {12, 11, 10, 9, 8};
            list.RemoveAt(0);
            Assert.AreEqual(4, list.Length);
            Assert.AreEqual(11, list.ElementAt(0));
        }

        [TestMethod]
        public void TestForEach()
        {
            ILinkedList list = new LinkedList { 12 , 11, 10, 9 };

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void TestRemoveFromTheMiddle()
        {
            LinkedList list = new LinkedList { 12, 11, 10, 9 };
            list.RemoveAt(2);
            Assert.AreEqual(3, list.Length);
            Assert.AreEqual(11, list.ElementAt(1));
            Assert.AreEqual(9, list.ElementAt(2));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void HavingRemovedAtWrongPositionShouldThrowException()
        {
            LinkedList list = new LinkedList();
            list.RemoveAt(2);
        }
    }
}
