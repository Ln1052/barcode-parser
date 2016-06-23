using System;

namespace BarcodeParser.Core
{
    public class StandardFactory
    {
        public IStandard GetStandard(string barcode)
        {
            // There is probably a regular expression pattern to match
            // This is just a quick implementation of a factory method.
            switch (barcode[0])
            {
                case '*':
                    return new Standards.StandardARev1();
                case '+':
                    return new Standards.StandardARev2();
                case '(':
                    return new Standards.StandardBRev1();
                default:
                    throw new ArgumentException("Invalid barcode input");
            }
        }
    }
}
