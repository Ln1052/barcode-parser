using System;

namespace BarcodeParser.Core.Standards
{
    public sealed class StandardARev1 : IStandard
    {
        internal StandardARev1() { }

        public string Name
        {
            get { return "Standard A"; }         
        }

        public string RevisionDate
        {
            get { return new DateTime(1993, 1, 10).ToShortDateString(); }
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

    public sealed class StandardARev2 : IStandard
    {
        internal StandardARev2() { }

        public string Name
        {
            get { return "Standard A"; }
        }

        public string RevisionDate
        {
            get { return new DateTime(2006, 5, 10).ToShortDateString(); }
        }

        public int RevisionNumber
        {
            get { return 2; }
        }

        public StockItem Parse(string barcode)
        {
            throw new NotImplementedException();
        }
    }
}
