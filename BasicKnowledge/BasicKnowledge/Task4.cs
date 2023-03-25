using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicKnowledge
{
    public class Task4
    {
        public int PairsNumber(int[] arr, int target)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target) { count++; }
                }
            }
            return count;
        }
    }

    public class TestTask4
    {
        [Test]
        public void Test1()
        {
            int[] arr = new int[] { 1, 3, 6, 2, 2, 0, 4, 5 };
            int target = 5;
            int actual = new Task4().PairsNumber(arr, target);
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            int[] arr = new int[] { 1, 3, 6, 2, 2, 0, 4, 5 };
            int target = 9;
            int actual = new Task4().PairsNumber(arr, target);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}
