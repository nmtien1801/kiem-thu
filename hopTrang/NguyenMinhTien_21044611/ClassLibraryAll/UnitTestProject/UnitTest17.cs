using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest17
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data17.csv", "data17#csv", DataAccessMethod.Sequential), DeploymentItem("data17.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();

            int year = int.Parse(TestContext.DataRow[0].ToString());
            int month = int.Parse(TestContext.DataRow[1].ToString());
            int day = int.Parse(TestContext.DataRow[2].ToString());


            bool result = bool.Parse(TestContext.DataRow[3].ToString());

            bool result_act = cls.IsValidDate(year, month, day);
            Assert.AreEqual(result, result_act);
        }
    }
}
