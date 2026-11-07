using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest21
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data21.csv", "data21#csv", DataAccessMethod.Sequential), DeploymentItem("data21.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            string tmp = TestContext.DataRow[0].ToString();

            int result = int.Parse(TestContext.DataRow[1].ToString());

            long result_act = cls.HexToDec(tmp);
            Assert.AreEqual(result, result_act);
        }
    }
}
