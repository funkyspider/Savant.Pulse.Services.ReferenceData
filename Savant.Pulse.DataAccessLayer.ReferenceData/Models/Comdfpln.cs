using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comdfpln
    {
        public DateTime Strtdate { get; set; }
        public string Pntycd { get; set; }
        public DateTime? Enddate { get; set; }
        public string Primtmpl { get; set; }
        public string Rmdtmpl { get; set; }
        public int? Wcomdays { get; set; }
        public int? Selndays { get; set; }
        public int? Closdays { get; set; }
        public int? Ccomdays { get; set; }
    }
}
