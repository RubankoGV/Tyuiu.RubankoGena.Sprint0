using NUnit.Framework.Legacy;
using Tiuiu.RubankoGena.Sprint0.Task7.V0.Lib;
namespace Tiuiu.RubankoGena.Sprint0.Task7.V0.Test
{
    public class DataServiceTests
    {
        public void CheckAdditionArraysValid()
        {
            int[] nums1 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums2 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums3 = new int[] { 2, 2, 2, 2, 2 };

            int[] res = DataService.AdditionArrays(nums1, nums2);
            CollectionAssert.AreEqual(nums3, res);
        }
    }
}