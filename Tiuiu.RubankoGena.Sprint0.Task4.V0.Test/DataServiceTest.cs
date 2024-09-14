using Tiuiu.RubankoGena.Sprint0.Task4.V0.Lib;

namespace Tiuiu.RubankoGena.Sprint0.Task4.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(10, DataService.Subtraction(10, 5));
        }

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(10, DataService.Multiplication(10, 5));
        }
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(10, DataService.Division(9, 3));
        }
    }
}