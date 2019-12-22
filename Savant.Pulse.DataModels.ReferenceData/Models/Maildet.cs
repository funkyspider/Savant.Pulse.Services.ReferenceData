using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Maildet
    {
        public string Doccode { get; set; }
        public string Docdesc { get; set; }
        public string Msgvalid { get; set; }
        public string Insvalid { get; set; }
        public string Inuse { get; set; }
        public int? Maxtext { get; set; }
        public int? Maxlines { get; set; }
    }
}
