using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace DHKTPM17B_Thong_DuyTien_MinhTien_Thu_Thuan
{
    [TestClass]
    public class UTLab6
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataUTLab6.csv", "DataUTLab6#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String s1 = TestContext.DataRow["s1"].ToString();
            String s2 = TestContext.DataRow["s2"].ToString();
            String s3 = TestContext.DataRow["s3"].ToString();
            String expected = TestContext.DataRow["rct"].ToString();

            String result = methodLibrary.ThayThe(s1, s2, s3);
            Console.WriteLine(result);

            Assert.AreEqual(expected, result);
        }
    }
}
