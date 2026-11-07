using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryAll;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data2.csv", "data2#csv",
            DataAccessMethod.Sequential),
            DeploymentItem("data2.csv"), TestMethod]
        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            int x = int.Parse(TestContext.DataRow[0].ToString());
            int y = int.Parse(TestContext.DataRow[1].ToString());
            int z = int.Parse(TestContext.DataRow[2].ToString());
            String result = TestContext.DataRow[3].ToString();

            string result_act = cls.CheckValue(x, y, z);
            Assert.AreEqual(result, result_act);
        }
    }
}
