using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarcodeParser.Core.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StandardFactoryTests()
        {
            var barcode = "*+A123BJC5D6E71G*";

            var expectedName = "Standard A";
            var expectedRevision = 1;
            var expectedRevisionDate = new DateTime(1993, 1, 10).ToShortDateString();

            var actual = new StandardFactory().GetStandard(barcode);

            Assert.AreEqual(expectedName, actual.Name);
            Assert.AreEqual(expectedRevision, actual.RevisionNumber);
            Assert.AreEqual(expectedRevisionDate, actual.RevisionDate);
        }
    }
}
