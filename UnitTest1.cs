using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaFigureLib;

namespace FormTest
{
    [TestClass]
    public class CircleTest
    {
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsZero()
        {
            Circle _ = new(0.0);
        }

        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsLessThanZero()
        {
            Circle _ = new(-0.5);
        }

        [TestMethod]
        public void CircleAreaDeltaCompute()
        {
            Circle crc = new(5.0);
            Assert.AreEqual(78.53981633, crc.GetArea, 1E-6, "Result out of range!");
        }

        public class TriangleTest
        {
            [ExpectedException(typeof(System.ArgumentException), "")]
            [TestMethod]
            public void SideIsZero()
            {
                Triangle _ = new(6.0, 0.0, 4.0);
            }

            [ExpectedException(typeof(System.ArgumentException), "")]
            [TestMethod]
            public void SideIsLessThanZero()
            {
                Triangle _ = new(6.0, 10.0, -4.0);
            }

            [ExpectedException(typeof(System.ArgumentException), "")]
            [TestMethod]
            public void TriangleNotExist()
            {
                Triangle _ = new(25, 10, 5);
            }

            [TestMethod]
            public void TriangleAreaDeltaCompute()
            {
                Triangle trg = new(40, 35, 25);
                Assert.AreEqual(433.0127018922, trg.GetArea, 1E-6, "Result out of range!");
            }

            [TestMethod]
            public void TriangleIsRight()
            {
                Triangle trg = new(17, 144, 145);
                Assert.IsTrue(trg.IsRight());
            }

            [TestMethod]
            public void TriangleIsNotRight()
            {
                Triangle trg = new(17, 144, 145.04);
                Assert.IsFalse(trg.IsRight());
            }
        }
    }
}