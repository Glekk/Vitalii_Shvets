using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicKnowledge
{
    public class ExtraTask1
    {
        public int NextBigger(int n)
        {
            int[] arr = n.ToString().Select(x => int.Parse(x.ToString())).ToArray();
            int len = arr.Length;

            int i = 0;
            for (i = len - 1; i > 0; i--)
            {
                if (arr[i] > arr[i - 1]) { break; }
            }
            if (i != 0)
            {
                for (int j = len - 1; j >= i; j--)
                {
                    if (arr[i - 1] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i - 1];
                        arr[i - 1] = temp;
                        break;
                    }
                }
                int[] nextBigger = new int[len];
                int ind = len - 1;

                for (int j = 0; j < i; j++)
                {
                    nextBigger[j] = arr[j];
                }
                for (int j = i; j < len; j++)
                {
                    nextBigger[j] = arr[ind--];
                }
                return int.Parse(string.Join("", nextBigger));
            }
            return -1;

        }
    }

    public class TestExtraTask1
    {
        [Test]
        public void Test1()
        {
            int n = 177;
            int actual = new ExtraTask1().NextBigger(n);
            int expected = 717;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            int n = 11;
            int actual = new ExtraTask1().NextBigger(n);
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test3()
        {
            int n = 534976;
            int actual = new ExtraTask1().NextBigger(n);
            int expected = 536479;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test4()
        {
            int n = 321;
            int actual = new ExtraTask1().NextBigger(n);
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }
    }
}
