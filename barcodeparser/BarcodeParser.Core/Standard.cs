using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeParser.Core
{
    // TODO: decide abstract class vs interface
    public abstract class Standard
    {
        // only getters?
        public string Name { get; set; }

        public int RevisionNumber { get; set; }

        public DateTime RevisionDate { get; set; }

    }
}
