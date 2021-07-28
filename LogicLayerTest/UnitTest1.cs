using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LogicLayerTest
{
    [TestClass]
    public class UnitTest1
    {

        #region Testing Int To Location Literal
        [TestMethod]
        public void IntToLocationNumeral_1_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(9).output;

            Assert.AreEqual("ad", response);
        }
        [TestMethod]
        public void IntToLocationNumeral_2_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(387).output;

            Assert.AreEqual("abhi", response);
        }
        [TestMethod]
        public void IntToLocationNumeral_3_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(67108864).output;

            Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", response);
        }

        [TestMethod]
        public void IntToLocationNumeral_4_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(67108865).output;

            Assert.AreEqual("abcdefghijklmnopqrstuvwxyza", response);
        }

        [TestMethod]
        public void IntToLocationNumeral_1_Bad()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(387).output;

            Assert.AreNotEqual("abhj", response);
        }
        [TestMethod]
        public void IntToLocationNumeral_2_Bad()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(67108864).output;

            Assert.AreNotEqual("z1", response);
        }

        [TestMethod]
        public void IntToLocationNumeral_3_Bad()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(67108865).output;

            Assert.AreNotEqual("az", response);
        }

        #endregion

        #region Testing Location numeral to Integer
        [TestMethod]
        public void LocationNumeralToInt_1_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToInt("ad").output;

            Assert.AreEqual("9", response);
        }

        [TestMethod]
        public void LocationNumeralToInt_2_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToInt("abhi").output;

            Assert.AreEqual("387", response);
        }
        [TestMethod]
        public void LocationNumeralToInt_3_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToInt("bcba").output;

            Assert.AreEqual("9", response);
        }
        [TestMethod]
        public void LocationNumeralToInt_4_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToInt("bcfgh").output;

            Assert.AreEqual("230", response);
        }

        #endregion

        #region Test Abbreviation
        [TestMethod]
        public void LocationNumeralToAbreviated_1_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToAbreviated("abbc").output;

            Assert.AreEqual("ad", response);
        }

        [TestMethod]
        public void LocationNumeralToAbreviated_2_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToAbreviated("aaaa").output;

            Assert.AreEqual("c", response);
        }

        [TestMethod]
        public void LocationNumeralToAbreviated_3_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToAbreviated("cac").output;

            Assert.AreEqual("ad", response);
        }

        [TestMethod]
        public void LocationNumeralToAbreviated_4_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToAbreviated("dddd").output;

            Assert.AreEqual("f", response);
        }
        #endregion

    }
}
