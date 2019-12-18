using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Dttype
    {
        public string Dtsyscd { get; set; }
        public string Dtincty { get; set; }
        public string Inctyds { get; set; }
        public string Inuse { get; set; }
        public string Valtype { get; set; }
        public int? Prio { get; set; }
        public string Datprmpt { get; set; }
        public string Lrule { get; set; }
    }
}
