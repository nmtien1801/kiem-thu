using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace DHKTPM17B_Thong_DuyTien_MinhTien_Thu_Thuan
{
    [TestClass]
    public class UTLab4
    {

        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataUTLab4.csv", "DataUTLab4#csv", DataAccessMethod.Sequential)]

        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long s;
            long s0 = Convert.ToInt64(TestContext.DataRow[0].ToString()); ;
            long act = o.Sum(s0, out s); // Đầu vào là S0 -> trả ra k++

            long expK = Convert.ToInt64(TestContext.DataRow[2].ToString()); ; // Giá trị mong đợi là K
            Assert.AreEqual(expK, act - 1); // So sánh giá trị thực tế với mong đợi 

            long expS = Convert.ToInt64(TestContext.DataRow[1].ToString()); ; // Với s0 = 14, giá trị của s sau khi tính toán sẽ là 15
            Assert.AreEqual(expS, s);
        }

    }
}
