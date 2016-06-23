using System;

namespace BarcodeParser.Core.Standards
{
    public sealed class StandardARev1 : IStandard
    {
        private string barcode;
        internal StandardARev1(string barcode)
        {
            this.barcode = barcode;
        }

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

        public StockItem Parse()
        {
            // Information as to how these standards are ACTUALLY parsed can be found here:
            // http://www.hibcc.org/publication/view/supplier-labeling-standard/
            // That being said, I will be returning static data for the purposes of this 
            // exercise as a PoC.

            var item = new StockItem(123, 456, null, new DateTime(2016, 12, 31));
            return item;
        }
    }

    public sealed class StandardARev2 : IStandard
    {
        private string barcode;

        internal StandardARev2(string barcode)
        {
            this.barcode = barcode;
        }

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

        public StockItem Parse()
        {
            // Information as to how these standards are ACTUALLY parsed can be found here:
            // http://www.hibcc.org/publication/view/supplier-labeling-standard/
            // That being said, I will be returning static data for the purposes of this 
            // exercise as a PoC. This will be different data than R1 to verify data is being parsed correctly.

            var item = new StockItem(555, 999, null, new DateTime(2016, 12, 30));
            return item;
        }
    }
}
