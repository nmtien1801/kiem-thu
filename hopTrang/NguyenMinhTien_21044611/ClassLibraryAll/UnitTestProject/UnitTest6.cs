using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryAll;
namespace UnitTestProject
{
   
    public class UnitTest6
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data6.csv", "data6#csv", DataAccessMethod.Sequential), DeploymentItem("data6.csv"), TestMethod]

        public void TestMethod1()
        {
            ClassAll cls = new ClassAll();
            int sum = int.Parse(TestContext.DataRow[0].ToString());
            int count = int.Parse(TestContext.DataRow[1].ToString());

            double result = double.Parse(TestContext.DataRow[2].ToString());

            double result_act = cls.Average(sum, count);
            Assert.AreEqual(result, result_act);
        }
    }
}
