using Tyuiu.MarkovSE.Sprint2.Task5.V7.Lib;
namespace Tyuiu.MarkovSE.Sprint2.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 14;
            Assert.AreEqual(ds.FindMonthName(1990, n), "Февраль");

        }
    }
}