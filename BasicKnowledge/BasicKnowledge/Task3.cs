using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicKnowledge
{
    public class Task3
    {
        public int DigitalRoot(int n)
        {
            int sum = 0;
            if (n < 10)
            {
                return n;
            }
            else
            {
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
            }
            return DigitalRoot(sum);
        }
    }

    public class TestTask3
    {
        [Test]
        public void Test1()
        {
            int actual = new Task3().DigitalRoot(493193);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            int actual = new Task3().DigitalRoot(12);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }
    }
}
