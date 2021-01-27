using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
namespace ЮнитТесты
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhatIfOneSideOfTrianfleIsZeroOrBelow()
        {
            Triangle fig = new Triangle
            {
                firstSide = 0,
                secondSide = -5
            };
            fig.IsSidesOkey();
            fig.CalcArea();
        }
       
    }
}
