using System;
using Lab03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MilesPerGallonTest
{
    [TestClass]
    public class MilesPerGallonTest
    {
        [TestMethod]
        public void HappyPathTest()
        {
            var actualMpg = new MilesPerGallon {Miles = 540, Gallons = 18}.Mpg;
            var expectedMpg = 30.0;
            Assert.AreEqual(expectedMpg, actualMpg, 0.1);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void NegativeMilesExceptionTest()
        {
            var actualMpg = new MilesPerGallon { Miles = -540, Gallons = 18 }.Mpg;
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void NegativeGallonsExceptionTest()
        {
            var actualMpg = new MilesPerGallon { Miles = 540, Gallons = -18 }.Mpg;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ZeroGallonsExceptionTest()
        {
            var actualMpg = new MilesPerGallon { Miles = 540, Gallons = 0 }.Mpg;
        }
    }
}
