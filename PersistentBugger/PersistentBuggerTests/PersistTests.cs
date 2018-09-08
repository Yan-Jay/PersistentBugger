using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersistentBugger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace PersistentBugger.Tests
{
    //[TestClass()]
    //public class PersistTests
    //{
    //    [TestMethod()]
    //    public void PersistenceTest()
    //    {
    //        Assert.Fail();
    //    }
    //}
    [TestFixture]
    public class PersistTests
    {

        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(3, Persist.Persistence(39));
            Assert.AreEqual(0, Persist.Persistence(4));
            Assert.AreEqual(2, Persist.Persistence(25));
            Assert.AreEqual(4, Persist.Persistence(999));
        }
    }
}