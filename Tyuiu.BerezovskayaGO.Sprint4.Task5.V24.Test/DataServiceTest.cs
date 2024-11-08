using Tyuiu.BerezovskayaGO.Sprint4.Task5.V24.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas4 = new int[5, 5] { { 5, -1, 5, 0, 5 },
                                          { 5, 5, 5, -5, 4 },
                                          { -5, 5, 5, -3, 1 },
                                          { -2, 5, 4, 4, 2 },
                                          { -5, 5, 0, -3, -4 } };

            int res = ds.Calculate(mas4);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}