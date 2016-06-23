namespace BarcodeParser.Core
{
    // TODO: decide abstract class vs interface
    public interface IStandard
    {
        string Name { get; }

        int RevisionNumber { get; }

        string RevisionDate { get; }

        //ASSUMPTION: each Standard has its own ruleset for parsing a barcode.
        // I had originally set this to take the barcode parameter. I realized
        // I could make use of constructor injection during the factory creation 
        // and get a cleaner API this way.
        StockItem Parse();
    }
}
