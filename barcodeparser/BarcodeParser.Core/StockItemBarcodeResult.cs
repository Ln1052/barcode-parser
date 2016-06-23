namespace BarcodeParser.Core
{
    public class StockItemBarcodeResult
    {
        public IStandard Standard { get; }
        public StockItem StockItem { get; }

        internal StockItemBarcodeResult(IStandard standard, StockItem stockItem)
        {
            this.Standard = standard;
            this.StockItem = stockItem;
        }
    }
}
