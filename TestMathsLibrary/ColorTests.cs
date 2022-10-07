using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class ColorTests
    {
        [TestMethod]
        public void ColorConstructor()
        {
            // homogeneous point translation
            Color c = new Color(0x12, 0x34, 0x56, 0x78);

            Assert.AreEqual<UInt32>(c.color, 0x12345678);
        }

        [TestMethod]
        public void ColorGetRed()
        {
            // homogeneous point translation
            Color c = new Color(0x12, 0x34, 0x56, 0x78);

            Assert.AreEqual<byte>(c.Red, 0x12);
        }

        [TestMethod]
        public void ColorGetGreen()
        {
            // homogeneous point translation
            Color c = new Color(0x12, 0x34, 0x56, 0x78);

            Assert.AreEqual<byte>(c.Green, 0x34);
        }


        [TestMethod]
        public void ColorGetBlue()
        {
            // homogeneous point translation
            Color c = new Color(0x12, 0x34, 0x56, 0x78);

            Assert.AreEqual<byte>(c.Blue, 0x56);
        }

        [TestMethod]
        public void ColourGetAlpha()
        {
            // homogeneous point translation
            Color c = new Color(0x12, 0x34, 0x56, 0x78);

            Assert.AreEqual<byte>(c.Alpha, 0x78);
        }

        [TestMethod]
        public void ColorSetRed()
        {
            // homogeneous point translation
            Color c = new Color();
            c.Red = 0x12;

            Assert.AreEqual<UInt32>(c.color, 0x12000000);
        }

        [TestMethod]
        public void ColorSetGreen()
        {
            // homogeneous point translation
            Color c = new Color();
            c.Green = 0x34;

            Assert.AreEqual<UInt32>(c.color, 0x00340000);
        }

        [TestMethod]
        public void ColorSetBlue()
        {
            // homogeneous point translation
            Color c = new Color();
            c.Blue = 0x56;

            Assert.AreEqual<UInt32>(c.color, 0x00005600);
        }

        [TestMethod]
        public void ColorSetAlpha()
        {
            // homogeneous point translation
            Color c = new Color();
            c.Alpha = 0x78;

            Assert.AreEqual<UInt32>(c.color, 0x00000078);
        }
    }
}
