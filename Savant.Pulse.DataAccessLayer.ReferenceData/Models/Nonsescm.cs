using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Nonsescm
    {
        public string Commscd { get; set; }
        public string Microreq { get; set; }
        public int? Microdur { get; set; }
        public string Groupreq { get; set; }
        public int? Groupdur { get; set; }
        public string Pantyp { get; set; }
        public string Pcinuse { get; set; }
        public string Nccuse { get; set; }
    }
}
