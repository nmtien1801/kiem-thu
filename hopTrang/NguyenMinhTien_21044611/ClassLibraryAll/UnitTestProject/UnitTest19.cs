using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest19
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data19.csv", "data19#csv", DataAccessMethod.Sequential), DeploymentItem("data19.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();

            int height = int.Parse(TestContext.DataRow[0].ToString());
            int weight = int.Parse(TestContext.DataRow[1].ToString());

            int result = int.Parse(TestContext.DataRow[2].ToString());

            int result_act = cls.BodyCheck(height, weight);
            Assert.AreEqual(result, result_act);
        }
    }
}
