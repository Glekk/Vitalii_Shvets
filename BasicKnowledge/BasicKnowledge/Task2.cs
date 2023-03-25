using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicKnowledge
{
    public class Task2
    {
        public string FirstNonRepeatingLetter(string input)
        {
            string lower = input.ToLower();
            for (int i = 0; i < lower.Length; i++)
            {
                if (lower.IndexOf(lower[i]) == lower.LastIndexOf(lower[i]))
                {
                    return input[i].ToString();
                }
            }
            return "";
        }
    }

    public class TestTask2
    {
        [Test]
        public void Test1()
        {
            string actual = new Task2().FirstNonRepeatingLetter("stress");
            string expected = "t";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            string actual = new Task2().FirstNonRepeatingLetter("asDSa");
            string expected = "D";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test3()
        {
            string actual = new Task2().FirstNonRepeatingLetter("aaaa");
            string expected = "";
            Assert.AreEqual(expected, actual);
        }
    }
}
