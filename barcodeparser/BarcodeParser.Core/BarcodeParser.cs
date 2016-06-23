using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeParser.Core
{
    public class BarcodeParser : IBarcodeParser<StockItem>
    {
        public StockItem GetBarcodeData(string barcode)
        {
            throw new NotImplementedException();
        }

        public StockItem GetBarcodeData(string barcode, IStandard standard)
        {
            throw new NotImplementedException();
        }
    }
}
