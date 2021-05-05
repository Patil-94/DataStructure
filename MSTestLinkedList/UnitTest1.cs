using DataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(30, true)]
        [DataRow(45, false)]
        public void Search_PassNodeValue_ReturnTrueOrFalse(int data, bool flag)
        {
            LinkedList list = new LinkedList();
            list.InsertFront(56);
            list.InsertFront(30);
            list.InsertFront(70);
            bool flagReturned = list.Search(data);
            Assert.AreEqual(flag, flagReturned);
        }
    }
}
