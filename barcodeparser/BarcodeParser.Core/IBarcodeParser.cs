namespace BarcodeParser.Core
{
    // Aware of YAGNI-possibility with making this generic.
    // Also aware of the possibility of extending functionality, i.e. employee IDs
    public interface IBarcodeParser<TEntity>
    {
        TEntity GetBarcodeData(string barcode);

        TEntity GetBarcodeData(string barcode, IStandard standard);
    }
}
