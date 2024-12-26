using Tyuiu.MarkovSE.Sprint2.Task4.V20.Lib;
namespace Tyuiu.MarkovSE.Sprint2.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 11;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 3.452;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 199;
            double res = ds.Calculate(x, y);
            double wait = 24.995;
            Assert.AreEqual(wait, res);
        }
    }
}