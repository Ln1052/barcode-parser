using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeParser.Core
{
    // TODO: decide abstract class vs interface
    public interface IStandard
    {
        // only getters?
        string Name { get; }

        int RevisionNumber { get; }

        string RevisionDate { get; }
    }
}
