using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
        [TestMethod]
        public void Test_for_1HGBH41JXMN109186()
        {
            Assert.AreEqual(class1.CheckVIN("1HGBH41JXMN109186"), true);
        }
        [TestMethod]
        public void Test_for_JTEBU29J10123456()
        {
            Assert.AreEqual(class1.CheckVIN("JTEBU29J101234576"), true);
        }
        [TestMethod]
        public void Test_for_KMHDU41BP8U437793()
        {
            Assert.AreEqual(class1.CheckVIN("KMHDU41BP8U432193"), true);
        }
        [TestMethod]
        public void Test_for_JN3MS37A9PW202929()
        {
            Assert.AreEqual(class1.CheckVIN("JN3MS37A9PW202929"), true);
        }
        [TestMethod]
        public void Test_for_WBAZZZ8A9KA123456()
        {
            Assert.AreEqual(class1.CheckVIN("WBAZZZ8A9KA154356"), true);
        }
        [TestMethod]
        public void Test_for_1HGBH41JXMN109186_Country()
        {
            Assert.AreEqual(class1.GetVINCountry("1HGBH41JXMN909186"), "Южная Америка");
        }
        [TestMethod]
        public void Test_for_JTEBU29J10123456_Country()
        {
            Assert.AreEqual(class1.GetVINCountry("JTEBU29J101234576"), "Северная Америка");
        }
        [TestMethod]
        public void Test_for_KMHDU41BP8U437793_Country()
        {
            Assert.AreEqual(class1.GetVINCountry("KMHDU41BP8U437793"), "Северная Америка");
        }
        [TestMethod]
        public void Test_for_JN3MS37A9PW202929_Country()
        {
            Assert.AreEqual(class1.GetVINCountry("JN3MS37A9PW202929"), "Северная Америка");
        }
        [TestMethod]
        public void Test_for_WBAZZZ8A9KA123456_Country()
        {
            Assert.AreEqual(class1.GetVINCountry("WBAZZZ8A9KA123456"), "Северная Америка");
        }


        [TestMethod]
        public void Test_for_WBAZZZ8A9KA123256()
        {
            Assert.AreEqual(class1.CheckVIN(""), false);
        }


        [TestMethod]
        public void Test_for_WBAZZZ8A9KA123256666_many()
        {
            Assert.AreEqual(class1.CheckVIN("WBAZZZ8A9KA123456666"), false);
        }

        [TestMethod]
        public void Test_for_WBAZZZ8A9KA_many()
        {
            Assert.AreEqual(class1.CheckVIN("WBAZZZ8A9KA"), false);
        }

        [TestMethod]
        public void Test_for_1()
        {
            Assert.AreEqual(class1.CheckVIN("1"), false);
        }

    }
}
