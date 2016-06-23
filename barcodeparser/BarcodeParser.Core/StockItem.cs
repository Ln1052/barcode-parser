using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeParser.Core
{
    public class StockItem
    {
        #region output members
        public int ItemNumber { get; set; }

        public int? Serial { get; set; }

        public int? Lot { get; set; }

        public DateTime ExpirationDate { get; set; }
        #endregion

        #region standard information
        public IStandard StandardInformation { get; set; }
        #endregion
    }
}
