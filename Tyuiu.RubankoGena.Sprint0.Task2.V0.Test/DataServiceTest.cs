using Tyuiu.RubankoGena.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RubankoGena.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void CheckGetMessageValid()
        {
            var name = "�����";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("������....., �����", res);
        }
    }
}