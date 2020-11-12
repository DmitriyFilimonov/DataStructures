using NUnit.Framework;
using DataStructure.LL;
using System;

namespace LLTests
{
    public class LinkedListTests
    {
        [TestCase(new int[] { 1, 2, 3 }, 1, 4, new int[] { 1, 4, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 3, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 0, 4, new int[] { 4 })]
        [TestCase(new int[] { 1 }, 0, 4, new int[] { 4, 1 })]
        public void AddByIndexTest(int[] array, int index, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.AddByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 5, 4)]
        public void AddByIndexTestNegative(int[] array, int index, int value)
        {
            LinkedList a = new LinkedList(array);


            Assert.Throws<IndexOutOfRangeException>(() => a.AddByIndex(index, value));
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 1 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { })]
        public void DeleteLastTest(int[] a, int[] b)
        {
            LinkedList expected = new LinkedList(b);
            LinkedList actual = new LinkedList(a);
            actual.DeleteLast();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        public void DeleteFirstTest(int[] a, int[] b)
        {
            LinkedList expected = new LinkedList(b);
            LinkedList actual = new LinkedList(a);
            actual.DeleteFirst();

            Assert.AreEqual(expected, actual);
        }
    }
}