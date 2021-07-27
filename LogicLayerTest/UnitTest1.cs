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

            var response = dm.IntToLocationNumeral(9).Output;

            Assert.AreEqual("ad", response);
        }
        [TestMethod]
        public void IntToLocationNumeral_2_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(387).Output;

            Assert.AreEqual("abhi", response);
        }
        [TestMethod]
        public void IntToLocationNumeral_3_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(67108864).Output;

            Assert.AreEqual("z", response);
        }

        [TestMethod]
        public void IntToLocationNumeral_4_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(67108865).Output;

            Assert.AreEqual("za", response);
        }

        [TestMethod]
        public void IntToLocationNumeral_1_Bad()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(387).Output;

            Assert.AreNotEqual("abhj", response);
        }
        [TestMethod]
        public void IntToLocationNumeral_2_Bad()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(67108864).Output;

            Assert.AreNotEqual("z1", response);
        }

        [TestMethod]
        public void IntToLocationNumeral_3_Bad()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.IntToLocationNumeral(67108865).Output;

            Assert.AreNotEqual("az", response);
        }

        #endregion

        #region Testing Location numeral to Integer
        [TestMethod]
        public void LocationNumeralToInt_1_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToInt("ad").Output;

            Assert.AreEqual("9", response);
        }

        [TestMethod]
        public void LocationNumeralToInt_2_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToInt("abhi").Output;

            Assert.AreEqual("387", response);
        }
        [TestMethod]
        public void LocationNumeralToInt_3_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToInt("bcba").Output;

            Assert.AreEqual("9", response);
        }
        [TestMethod]
        public void LocationNumeralToInt_4_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToInt("bcfgh").Output;

            Assert.AreEqual("230", response);
        }

        #endregion

        #region Test Abbreviation
        [TestMethod]
        public void LocationNumeralToAbreviated_1_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToAbreviated("abbc").Output;

            Assert.AreEqual("ad", response);
        }

        [TestMethod]
        public void LocationNumeralToAbreviated_2_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToAbreviated("aaaa").Output;

            Assert.AreEqual("c", response);
        }

        [TestMethod]
        public void LocationNumeralToAbreviated_3_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToAbreviated("cac").Output;

            Assert.AreEqual("ad", response);
        }

        [TestMethod]
        public void LocationNumeralToAbreviated_4_Ok()
        {
            DataManagerClass dm = new DataManagerClass();

            var response = dm.LocationNumeralToAbreviated("dddd").Output;

            Assert.AreEqual("f", response);
        }
        #endregion

    }
}
