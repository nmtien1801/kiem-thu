using ClassLibraryAll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest20
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data20.csv", "data20#csv", DataAccessMethod.Sequential), DeploymentItem("data20.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();

            char tmp = char.Parse(TestContext.DataRow[0].ToString());

            int result = int.Parse(TestContext.DataRow[1].ToString());

            int result_act = cls.isInString(tmp);
            Assert.AreEqual(result, result_act);
        }
    }
}
