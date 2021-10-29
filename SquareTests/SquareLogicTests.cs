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
            var square = new SquareLogic(38, MeasureType.m2);
            Assert.AreEqual("38 ", square.Verbose());
        }

        [TestMethod()]
        public void AddNumberTest()
        {
            var square = new SquareLogic(1, MeasureType.m2);
            square = square + 4.25;
            Assert.AreEqual("5,25 ", square.Verbose());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var square = new SquareLogic(3, MeasureType.m2);
            square = square - 1.75;
            Assert.AreEqual("1,25 ", square.Verbose());
        }

        [TestMethod()]
        public void MulByNumberTest()
        {
            var square = new SquareLogic(3, MeasureType.m2);
            square = square * 3;
            Assert.AreEqual("9 ", square.Verbose());
        }
       
        [TestMethod()]
        public void ComparisonTest()
        {
            string str = "";
            var square1 = new SquareLogic(3, MeasureType.га);
            var square2 = new SquareLogic(9, MeasureType.m2);
            if (square1 > square2)
            {
                str = "Первое больше";
            }
            Assert.AreEqual("Первое больше", str);
        }

        [TestMethod()]
        public void MeterToAnyTest()
        {
            SquareLogic square;

            square = new SquareLogic(10000, MeasureType.m2);
            Assert.AreEqual("1 ", square.To(MeasureType.га).Verbose());

            square = new SquareLogic(100 * 2, MeasureType.m2);
            Assert.AreEqual("2 ", square.To(MeasureType.а).Verbose());

            square = new SquareLogic(3 * 10925, MeasureType.m2);
            Assert.AreEqual("3 ", square.To(MeasureType.д).Verbose());
        }
        [TestMethod()]
        public void AnyToMeterTest()
        {
            SquareLogic square;

            square = new SquareLogic(1, MeasureType.га);
            Assert.AreEqual("10000 ", square.To(MeasureType.m2).Verbose());

            square = new SquareLogic(1, MeasureType.а);
            Assert.AreEqual("100 ", square.To(MeasureType.m2).Verbose());

            square = new SquareLogic(1, MeasureType.д);
            Assert.AreEqual("10925 ", square.To(MeasureType.m2).Verbose());
        }
        [TestMethod()]
        public void AddSubGaMetersTest()
        {
            var m2 = new SquareLogic(100, MeasureType.m2);
            var ga = new SquareLogic(1, MeasureType.га);

                Assert.AreEqual("10100 ", (m2 + ga).Verbose());
                Assert.AreEqual("1,01 ", (ga + m2).Verbose());

                Assert.AreEqual("0,99 ", (ga - m2).Verbose());
                Assert.AreEqual("-9900 ", (m2 - ga).Verbose());
        }
    }
}