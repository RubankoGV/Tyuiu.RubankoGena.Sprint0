using Tiuiu.RubankoGena.Sprint0.Task3.V0.Lib;

namespace Tiuiu.RubankoGena.Sprint0.Task3.V0.Test
{
    public class DataServiceTest
    {
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}