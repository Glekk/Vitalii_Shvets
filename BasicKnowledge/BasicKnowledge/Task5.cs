using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicKnowledge
{
    public class Task5
    {
        public string FriendsList(string s)
        {
            string upper = s.ToUpper();
            ILookup<string, string> lookup = upper.Split(';').ToLookup(x => x.Split(':')[1], x => x.Split(':')[0]);
            string[] split = upper.Split(';');

            var sorted = from item in split
                         let key = item.Split(':')[1]
                         let value = item.Split(':')[0]
                         orderby key, value
                         select new { key, value };

            string result = "";
            foreach (var elem in sorted)
            {
                result += "(" + elem.key + ", " + elem.value + ")";
            }

            return result;
        }
    }

    public class TestTask5
    {
        [Test]
        public void Test1()
        {
            string s = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string actual = new Task5().FriendsList(s);
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            string s = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Wilfred:Corwill";
            string actual = new Task5().FriendsList(s);
            string expected = "(CORWILL, FRED)(CORWILL, WILFRED)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)";
            Assert.AreEqual(expected, actual);
        }
    }
}
