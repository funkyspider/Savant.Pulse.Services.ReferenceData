using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sesscmdt
    {
        public string Commscd { get; set; }
        public string Isinsert { get; set; }
        public string Msgvalid { get; set; }
        public string Insvalid { get; set; }
        public int? Maxtext { get; set; }
        public int? Maxlines { get; set; }
        public int? Insprio { get; set; }
    }
}
