using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeParser.Core
{
    public class StockItemBarcodeParser : IBarcodeParser<StockItemBarcodeResult>
    {
        public StockItemBarcodeResult GetBarcodeData(string barcode)
        {
            var standard = new StandardFactory().GetStandard(barcode);
            return this.BuildResultObject(barcode, standard);
        }

        public StockItemBarcodeResult GetBarcodeData(string barcode, IStandard standard)
        {
            return this.BuildResultObject(barcode, standard);
        }

        private StockItemBarcodeResult BuildResultObject(string barcode, IStandard standard)
        {
            var stockItem = standard.Parse();
            return new StockItemBarcodeResult(standard, stockItem);
        }
    }
}
