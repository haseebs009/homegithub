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
            Calculator obj = new Calculator();
             Assert.AreEqual(50, obj.penaltyCalculator(11, 0));
           
        }
    }
}
