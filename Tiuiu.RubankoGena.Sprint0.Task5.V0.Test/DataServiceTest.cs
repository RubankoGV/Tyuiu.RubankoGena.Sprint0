using Tiuiu.RubankoGena.Sprint0.Task5.V0.Lib;

namespace Tiuiu.RubankoGena.Sprint0.Task5.V0.Test
{
    public class DataServiceTest
    {
        public void CheckedAdditionValid()
            {
                Assert.AreEqual(10, DataService.Addition(5, 5));
            }

            public void CheckedSubtractionValid()
            {
                Assert.AreEqual(5, DataService.Subtraction(10, 5));
            }

            public void CheckedMultiplicationValid()
            {
                Assert.AreEqual(50, DataService.Multiplication(10, 5));
            }
            public void CheckedDivisionValid()
            {
                Assert.Arequal(3, DataService.Division(9, 3));
            }
        }
    }