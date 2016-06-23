namespace BarcodeParser.Core
{
    public class BarcodeResult
    {
        public IStandard standard { get; }
        public StockItem stockItem { get; }

        public BarcodeResult(IStandard standard, StockItem stockItem)
        {
            this.standard = standard;
            this.stockItem = stockItem;
        }
    }
}
