using Tyuiu.BerezovskayaGO.Sprint4.Task7.V9.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "864299753";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}