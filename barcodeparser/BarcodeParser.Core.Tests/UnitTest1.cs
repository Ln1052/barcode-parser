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

        [TestMethod]
        public void StandardFactoryRevision2Test()
        {
            var barcode = "+A123BJC5D6E71G*";

            var expectedName = "Standard A";
            var expectedRevision = 2;
            var expectedRevisionDate = new DateTime(2006, 5, 10).ToShortDateString();

            var actual = new StandardFactory().GetStandard(barcode);

            Assert.AreEqual(expectedName, actual.Name);
            Assert.AreEqual(expectedRevision, actual.RevisionNumber);
            Assert.AreEqual(expectedRevisionDate, actual.RevisionDate);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void StandardFactoryInvalidFormatTest()
        {
            var barcode = "xA123BJC5D6E71G*";
            var actual = new StandardFactory().GetStandard(barcode);
        }

        [TestMethod]
        public void StandardRevision1ParserTest()
        {
            var barcode = "*+A123BJC5D6E71G*";
            var expectedStockItemNumber = 123;
            var expectedStockItemSerial = 456;
            var expectedExpirationDate = new DateTime(2016, 12, 31);

            var actual = new StandardFactory().GetStandard(barcode).Parse();
            Assert.AreEqual(expectedStockItemNumber, actual.ItemNumber);
            Assert.AreEqual(expectedStockItemSerial, actual.Serial);
            Assert.IsNull(actual.Lot);
            Assert.AreEqual(expectedExpirationDate, actual.ExpirationDate);
        }

        [TestMethod]
        public void IBarcodeScannerTest()
        {
            var barcode = "+A123BJC5D6E71G*";
            var scanner = new StockItemBarcodeParser();

            // stockitem setup
            var expectedStockItemNumber = 555;
            var expectedStockItemSerial = 999;
            var expectedExpirationDate = new DateTime(2016, 12, 30);

            // barcode standard format data setup
            var expectedStandardName = "Standard A";
            var expectedStandardRevision = 2;
            var expectedStandardRevisionDate = new DateTime(2006, 5, 10).ToShortDateString();

            var actual = scanner.GetBarcodeData(barcode);
            // stockitem validation
            Assert.AreEqual(expectedStockItemNumber, actual.StockItem.ItemNumber);
            Assert.AreEqual(expectedStockItemSerial, actual.StockItem.Serial);
            Assert.AreEqual(expectedExpirationDate, actual.StockItem.ExpirationDate);
            Assert.IsNull(actual.StockItem.Lot);

            // standards validation
            Assert.AreEqual(expectedStandardName, actual.Standard.Name);
            Assert.AreEqual(expectedStandardRevision, actual.Standard.RevisionNumber);
            Assert.AreEqual(expectedStandardRevisionDate, actual.Standard.RevisionDate);
        }
    }
}
