using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryAll;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest7
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data7.csv", "data7#csv", DataAccessMethod.Sequential), DeploymentItem("data7.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            int month = int.Parse(TestContext.DataRow[0].ToString());
            int year = int.Parse(TestContext.DataRow[1].ToString());

            int result = int.Parse(TestContext.DataRow[2].ToString());

            int result_act = cls.DayInMonth(year, month);
            Assert.AreEqual(result, result_act);
        }
    }
}
