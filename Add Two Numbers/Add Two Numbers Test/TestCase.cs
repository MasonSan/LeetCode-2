using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Add_Two_Numbers;
using System.Collections.Generic;

namespace Add_Two_Numbers_Test
{
    [TestClass]
    public class TestCase
    {
        [TestMethod]
        public void Given_2_4_3_and_5_6_4_should_return_7_0_8()
        {
            //arrange
            var target = new Solution();
            var list1 = new List<int>() { 2, 4, 3 };
            var list2 = new List<int>() { 5, 6, 4 };
            var expected = new List<int>() { 7, 0, 8 };

            //action
            List<int> actual = target.AddTwoNumbers(list1, list2);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
