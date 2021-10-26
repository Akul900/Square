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

        [TestMethod()]
        public void AddNumberTest()
        {
            var square = new SquareLogic(1, MeasureType.m2);
            square = square + 4.25;
            Assert.AreEqual("5,25 m2.", square.Verbose());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var length = new SquareLogic(3, MeasureType.m2);
            length = length - 1.75;
            Assert.AreEqual("1,25 m2.", length.Verbose());
        }

        [TestMethod()]
        public void MulByNumberTest()
        {
            var length = new SquareLogic(3, MeasureType.m2);
            length = length * 3;
            Assert.AreEqual("9 m2.", length.Verbose());
        }

        [TestMethod()]
        public void DivByNumberTest()
        {
            var length = new SquareLogic(3, MeasureType.m2);
            length = length / 3;
            Assert.AreEqual("1 m2.", length.Verbose());
        }
        [TestMethod()]
        public void MeterToAnyTest()
        {
            SquareLogic square;

            square = new SquareLogic(10000, MeasureType.m2);
            Assert.AreEqual("1 га.", square.To(MeasureType.га).Verbose());

            square = new SquareLogic(100 * 2, MeasureType.m2);
            Assert.AreEqual("2 а.", square.To(MeasureType.а).Verbose());

            square = new SquareLogic(3 * 10925, MeasureType.m2);
            Assert.AreEqual("3 д.", square.To(MeasureType.д).Verbose());
        }
        [TestMethod()]
        public void AnyToMeterTest()
        {
            SquareLogic square;

            square = new SquareLogic(1, MeasureType.га);
            Assert.AreEqual("10000 m2.", square.To(MeasureType.m2).Verbose());

            square = new SquareLogic(1, MeasureType.а);
            Assert.AreEqual("100 m2.", square.To(MeasureType.m2).Verbose());

            square = new SquareLogic(1, MeasureType.д);
            Assert.AreEqual("10925 m2.", square.To(MeasureType.m2).Verbose());
        }
        [TestMethod()]
        public void AddSubKmMetersTest()
        {
            var m2 = new SquareLogic(100, MeasureType.m2);
            var ga = new SquareLogic(1, MeasureType.га);

            Assert.AreEqual("10100 m2.", (m2 + ga).Verbose());
            Assert.AreEqual("1,01 га.", (ga + m2).Verbose());

            Assert.AreEqual("0,99 га.", (ga - m2).Verbose());
            Assert.AreEqual("-9900 m2.", (m2 - ga).Verbose());
        }
    }
}