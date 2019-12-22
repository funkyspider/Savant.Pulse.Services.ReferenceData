using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Telnoref
    {
        public string Telnprfx { get; set; }
        public string Status { get; set; }
        public string Teltext { get; set; }
        public string Cnvtelno { get; set; }
        public int? Tellen { get; set; }
    }
}
