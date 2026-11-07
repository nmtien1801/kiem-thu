using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryAll;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest4
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data4.csv", "data4#csv", DataAccessMethod.Sequential), DeploymentItem("data4.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            int max_exp = int.Parse(TestContext.DataRow[3].ToString());
            int max_act = cls.Max(a, b, c);
            Assert.AreEqual(max_exp, max_act);
        }
    }
}
