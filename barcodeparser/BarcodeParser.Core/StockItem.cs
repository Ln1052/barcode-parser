using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeParser.Core
{
    public class StockItem
    {
        internal StockItem(int itemNumber, int? serial, int? lot, DateTime expirationDate)
        {
            this.ItemNumber = itemNumber;
            this.Serial = serial;
            this.Lot = lot;
            this.ExpirationDate = expirationDate;
        }

        public int ItemNumber { get; }

        public int? Serial { get; set; }

        public int? Lot { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
