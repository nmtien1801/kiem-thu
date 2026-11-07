using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace DHKTPM17B_Thong_DuyTien_MinhTien_Thu_Thuan
{
    [TestClass]
    public class UTLab5
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataUTLab5.csv", "DataUTLab5#csv", DataAccessMethod.Sequential),
            DeploymentItem("DataUTLab5.csv"), TestMethod]

        public void TestMethod1()
        {
            String s = "abcde";
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int n = Convert.ToInt32(TestContext.DataRow["n"]);
            int p = Convert.ToInt32(TestContext.DataRow["p"]);
            String expected = TestContext.DataRow["rct"].ToString();

            String result = methodLibrary.HuyChuoi(s, n, p);
            Console.WriteLine(result);

            Assert.AreEqual(expected, result);
        }
    }
}
