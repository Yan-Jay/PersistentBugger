using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersistentBugger;

namespace PersistentBuggerTests
{
    [TestClass()]
    public class PersistTests
    {
        [DataTestMethod]
        [DataRow(39, 3, DisplayName = "39 should return 3")]
        [DataRow(4, 0, DisplayName = "4 should return 0")]
        [DataRow(25, 2, DisplayName = "25 should return 2")]
        [DataRow(999, 4, DisplayName = "999 should return 4")]
        public void PersistenceTest(int input, int expected)
        {
            var actural = new Persist().Persistence(input);
            Assert.AreEqual(expected, actural);
        }
    }
}