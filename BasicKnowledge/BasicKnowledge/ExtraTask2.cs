using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicKnowledge
{
    public class ExtraTask2
    {
        public string UintToIp(uint n)
        {
            string ip = "";
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    ip = (n % 256) + ip;
                }
                else
                {
                    ip = (n % 256) + "." + ip;
                }
                n /= 256;
            }

            return ip;
        }
    }

    public class TestExtraTask2
    {
        [Test]
        public void Test1()
        {
            uint n = 2149583361;
            string actual = new ExtraTask2().UintToIp(n);
            string expected = "128.32.10.1";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            uint n = 32;
            string actual = new ExtraTask2().UintToIp(n);
            string expected = "0.0.0.32";
            Assert.AreEqual(expected, actual);
        }
    }
}
