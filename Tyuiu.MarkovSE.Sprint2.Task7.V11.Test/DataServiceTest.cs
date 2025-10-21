using Tyuiu.MarkovSE.Sprint2.Task7.V11.Lib;
namespace Tyuiu.MarkovSE.Sprint2.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            var res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}