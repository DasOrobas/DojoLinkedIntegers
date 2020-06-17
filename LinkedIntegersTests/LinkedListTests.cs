namespace LinkedIntegersTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using LinkedListLibrary;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class LinkedListExtensionTests
    {
        [TestMethod]
        public void InsertInteger_ListIsEmpty_IntegerIsInTheList()
        {
            var list = new LinkedList<int>();
            list.InsertIntegerInAscendingOrder(12);

            Assert.IsTrue(list.Contains(12));
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void InsertInteger_FallsBetweenOrderedValues_IntegerInsertedCorrectly()
        {
            var list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);            
            list.AddLast(15);
            list.AddLast(16);
            
            list.InsertIntegerInAscendingOrder(12);

            CollectionAssert.AreEqual(new List<int> { 2, 3, 12, 15, 16 }, list.ToList<int>());
        }

        [TestMethod]
        public void InsertInteger_FallsBetweenUnorderedValues_ListOrderedAndIntegerInsertedCorrectly()
        {
            var list = new LinkedList<int>();
            list.AddLast(16);
            list.AddLast(3);
            list.AddLast(2);
            list.AddLast(15);

            list.InsertIntegerInAscendingOrder(12);

            CollectionAssert.AreEqual(new List<int> { 2, 3, 12, 15, 16 }, list.ToList<int>());
        }
    }
}
