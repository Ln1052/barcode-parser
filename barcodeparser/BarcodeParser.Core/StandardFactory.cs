using System;

namespace BarcodeParser.Core
{
    public class StandardFactory
    {
        public IStandard GetStandard(string barcode)
        {
            // This is a very quick 'leading character' way of extrapolating the type of standard used.
            // This is not meant to be a final implementation.
            
            switch (barcode[0])
            {
                case '*':
                    return new Standards.StandardARev1(barcode);
                case '+':
                    return new Standards.StandardARev2(barcode);
                case '(':
                    return new Standards.StandardBRev1();
                default:
                    throw new ArgumentException("Invalid barcode input");
            }
        }
    }
}
