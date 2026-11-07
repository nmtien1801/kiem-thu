using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryAll;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest10
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data10.csv", "data10#csv", DataAccessMethod.Sequential), DeploymentItem("data10.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());
            float c = float.Parse(TestContext.DataRow[2].ToString());

            bool result = bool.Parse(TestContext.DataRow[3].ToString());

            bool result_act = cls.KiemTraTamGiac(a, b, c);
            Assert.AreEqual(result, result_act);
        }
    }
}
