using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryAll;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest5
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data5.csv", "data5#csv", DataAccessMethod.Sequential), DeploymentItem("data5.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();

            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            String exp = TestContext.DataRow[3].ToString();
            String act = cls.Triangle(a, b, c);
            Assert.AreEqual(exp, act);
        }
    }
}
