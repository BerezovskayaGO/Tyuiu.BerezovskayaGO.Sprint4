using Tyuiu.BerezovskayaGO.Sprint4.Task2.V17.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 315;
            Assert.AreEqual(wait, res);
        }
    }
}