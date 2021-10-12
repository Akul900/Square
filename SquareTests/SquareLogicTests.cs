using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Tests
{
    [TestClass()]
    public class SquareLogicTests
    {
        [TestMethod()]
        public void VerboseTest()
        {
            // тестируем все четыре типа
            var length = new SquareLogic(38, MeasureType.m2);
            Assert.AreEqual("38 m2.", length.Verbose());

            length = new SquareLogic(38, MeasureType.га);
            Assert.AreEqual("38 га.", length.Verbose());

            length = new SquareLogic(38, MeasureType.а);
            Assert.AreEqual("38 а.", length.Verbose());

            length = new SquareLogic(38, MeasureType.д);
            Assert.AreEqual("38 д.", length.Verbose());
        }
    }
}