using Tyuiu.BerezovskayaGO.Sprint4.Task6.V25.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var x = new string[] { "������", "������", "������", "���������", "�������", "�����", "������" };
            int res = ds.Calculate(x);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}