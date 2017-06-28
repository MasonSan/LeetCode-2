using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Add_Two_Numbers;
using System.Collections.Generic;
using ExpectedObjects;

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
            var number1 = new ListNode(2);
            number1.next = new ListNode(4);
            number1.next.next = new ListNode(3);

            var number2 = new ListNode(5);
            number2.next = new ListNode(6);
            number2.next.next = new ListNode(4);

            ExpectedObject expexted = new ListNode(7)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(8)
                }
            }.ToExpectedObject();
                                        

            //act
            ListNode actual = target.AddTwoNumbers(number1, number2);

            //assert
            expexted.ShouldEqual(actual);
            
        }
    }
}
