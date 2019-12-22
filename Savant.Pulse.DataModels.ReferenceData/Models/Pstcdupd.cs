using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pstcdupd
    {
        public string Ptable { get; set; }
        public string Pcolumn { get; set; }
        public string Keycol1 { get; set; }
        public string Keycol2 { get; set; }
        public string Keycol3 { get; set; }
        public string Keycol4 { get; set; }
        public string Nongeogp { get; set; }
    }
}
