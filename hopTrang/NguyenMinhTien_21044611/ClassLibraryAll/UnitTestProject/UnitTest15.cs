using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest15
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data15.csv", "data15#csv", DataAccessMethod.Sequential), DeploymentItem("data15.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();

            int year = int.Parse(TestContext.DataRow[0].ToString());

            bool result = bool.Parse(TestContext.DataRow[1].ToString());

            bool result_act = cls.KiemTraNamNhuan(year);
            Assert.AreEqual(result, result_act);
        }
    }
}
