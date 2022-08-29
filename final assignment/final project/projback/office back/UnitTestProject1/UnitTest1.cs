using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using penaltycal;
using penaltycal.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Test for one day penalty for Pakistan
            Calculator obj = new Calculator();
             Assert.AreEqual(50, obj.penaltyCalculator(11, 0));
           
        }
        [TestMethod]
        public void TestMethod2()
        {   // Test for one day penalty for UAE
            Calculator obj = new Calculator();
            Assert.AreEqual(54, obj.penaltyCalculator(11, 8));

        }
        [TestMethod]
        public void TestMethod3()
        {
            // Test for 0 penalty for Pakistan
            Calculator obj = new Calculator();
            Assert.AreEqual(0, obj.penaltyCalculator(10, 0));

        }
        [TestMethod]
        public void TestMethod4()
        {   // Test for 0 penalty for UAE
            Calculator obj = new Calculator();
            Assert.AreEqual(0, obj.penaltyCalculator(10, 8));

        }



    }
}
