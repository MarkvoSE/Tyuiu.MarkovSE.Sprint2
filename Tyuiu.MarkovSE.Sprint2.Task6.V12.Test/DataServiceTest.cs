using Tyuiu.MarkovSE.Sprint2.Task6.V12.Lib;
namespace Tyuiu.MarkovSE.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 1992, m = 04, n = 01;
            var res = ds.FindDateOfPreviousDay(g, m, n);

            Assert.AreEqual("31.03.1992", res);
        }
    }
}