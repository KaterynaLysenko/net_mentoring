using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLengthAndAdd()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add("string");
            list.Add(true);

            Assert.AreEqual(3, list.Length());
        }

        [TestMethod]
        public void TestAddAtFirstPosition()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.AddAt(4, 0);
            Assert.AreEqual(4, list.EllementAt(0));
        }

        [TestMethod]
        public void TestAddAtLastPosition()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.AddAt(4, 2);

            Assert.AreEqual(4, list.EllementAt(2));
        }
        [TestMethod]
        public void TestAddAtTheMiddle()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.AddAt(4, 1);
            Assert.AreEqual(4, list.EllementAt(1));
        }

        [TestMethod]
        public void TestRemoveFromTheEnd()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.Remove();
    
            Assert.AreEqual(2, list.Length());
            Assert.AreEqual(11, list.EllementAt(1));
        }

        [TestMethod]
        public void TestRemoveFromTheEndIfOnlyOneElementPresent()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Remove();

            Assert.AreEqual(0, list.Length());
        }

        [TestMethod]
        public void TestRemoveFromTheBeginning()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.Add(9);
            list.Add(8);
            list.RemoveAt(0);
            Assert.AreEqual(4, list.Length());
            Assert.AreEqual(11, list.EllementAt(0));
        }

        [TestMethod]
        public void TestForEach()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.Add(9);
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void TestRemoveFromTheMiddle()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.Add(9);
            list.RemoveAt(2);
            Assert.AreEqual(3, list.Length());
            Assert.AreEqual(11, list.EllementAt(1));
            Assert.AreEqual(9, list.EllementAt(2));
        }
    }
}
