﻿using Epam.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestContainsIfOnlyOneEllementPresent()
        {
            MyHashTable hashTable = new MyHashTable();
            hashTable.Add("kate", "lysenko");
            Assert.IsTrue(hashTable.Contains("kate"));
        }

        [TestMethod]
        public void TestContainsWhenSeveralEllements()
        {
            MyHashTable hashTable = new MyHashTable();
            hashTable.Add("kate", "lysenko");
            hashTable.Add("maryna", "zlotko");
            hashTable.Add(1, true);
            Assert.IsTrue(hashTable.Contains("kate"));
        }

        [TestMethod]
        public void TestContainsInTheMiddleWhenSeveralEllements()
        {
            MyHashTable hashTable = new MyHashTable();
            hashTable.Add("kate", "lysenko");
            hashTable.Add("maryna", "zlotko");
            hashTable.Add(1, true);
            Assert.IsTrue(hashTable.Contains("maryna"));
        }

        [TestMethod]
        public void TestContainsLastWhenSeveralEllements()
        {
            MyHashTable hashTable = new MyHashTable();
            hashTable.Add("kate", "lysenko");
            hashTable.Add("maryna", "zlotko");
            hashTable.Add(1, true);
            Assert.IsTrue(hashTable.Contains(1));
        }

        [TestMethod]
        public void TestContainsIfNotPresent()
        {
            MyHashTable hashTable = new MyHashTable();
            hashTable.Add("kate", "lysenko");
            hashTable.Add("maryna", "zlotko");
            hashTable.Add(1, true);
            Assert.IsFalse(hashTable.Contains("KeyNotPresent"));
        }

        [TestMethod]
        public void TestTryGet()
        {
            MyHashTable hashTable = new MyHashTable();
            hashTable.Add("kate", "lysenko");
            hashTable.Add("maryna", "zlotko");
            hashTable.Add(1, true);
            object testValue;
            hashTable.TryGet("kate", out testValue);
            Assert.AreEqual("lysenko", testValue);
        }

        [TestMethod]
        public void TestTryGetIfNotPresent()
        {
            MyHashTable hashTable = new MyHashTable();
            hashTable.Add("kate", "lysenko");
            hashTable.Add("maryna", "zlotko");
            hashTable.Add(1, true);
            object testValue;
            hashTable.TryGet("notPresent", out testValue);
            Assert.IsNull(testValue);
        }

        [TestMethod]
        public void TestGet()
        {
            MyHashTable hashTable = new MyHashTable();
            hashTable.Add("kate", "lysenko");
            hashTable.Add("maryna", "zlotko");
            hashTable.Add(1, true);
            Assert.AreEqual("zlotko", hashTable["maryna"]);
        }

        [TestMethod]
        public void TestSet()
        {
            MyHashTable hashTable = new MyHashTable();
            hashTable.Add("kate", "lysenko");
            hashTable.Add("maryna", "zlotko");
            hashTable.Add(1, true);
            hashTable["maryna"] = "gybelynda";
            Assert.AreEqual("gybelynda", hashTable["maryna"]);
        }

        [ExpectedException(typeof(ElementAlreadyPresentException))]
        [TestMethod]
        public void GivenExceptionIfAddElementWhithTheSameKey()
        {            
            MyHashTable hashTable = new MyHashTable();
            hashTable.Add("kate", "lysenko");
            hashTable.Add("kate", "lysenko");
           
        }

        [TestMethod]
        public void AddingValueUsingKeyShouldGetThatValueThen()
        {
            const string expectedValue = "tkachenko";
            var hashTable = new MyHashTable();
            hashTable["igor"] = expectedValue;
            Assert.AreEqual(expectedValue, hashTable["igor"]);
        }
    }
}
  