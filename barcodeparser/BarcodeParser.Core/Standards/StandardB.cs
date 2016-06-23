using System;

namespace BarcodeParser.Core.Standards
{
    internal class StandardBRev1 : IStandard
    {
        public string Name
        {
            get { return "Standard B"; }
        }

        public string RevisionDate
        {
            get { return new DateTime(1989, 3, 1).ToShortDateString(); }
        }

        public int RevisionNumber
        {
            get { return 1; }
        }

        public StockItem Parse(string barcode)
        {
            throw new NotImplementedException();
        }
    }
}