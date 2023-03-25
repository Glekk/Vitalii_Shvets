using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace BasicKnowledge
{
    public class Task1
    {
        public List<int> GetIntegersFromList(List<object> list)
        {
            List<int> result = list.OfType<int>().ToList();
            return result;
        }
    }

    public class TestTask1
    {
        [Test]
        public void Test1()
        {
            List<object> exampleInput = new List<object>() { 1, 2, 'a', 'b' };
            List<int> actual = new Task1().GetIntegersFromList(exampleInput);
            List<int> expected = new List<int>() { 1, 2 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            List<object> exampleInput = new List<object>() { 1, 2, 'a', 'b', 0, 15 };
            List<int> actual = new Task1().GetIntegersFromList(exampleInput);
            List<int> expected = new List<int>() { 1, 2, 0, 15 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
