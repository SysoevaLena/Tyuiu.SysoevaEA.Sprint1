using Tyuiu.SysoevaEA.Sprint1.Task6.V16.Lib;

namespace Tyuiu.SysoevaEA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "123? 7832!";
            bool wait = true;
            bool res = x.Contains('?') && x.Contains('!');
            Assert.AreEqual(wait, res);
        }
    }
}
