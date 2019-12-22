using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mrgfield
    {
        public string Donfield { get; set; }
        public string Fielddsc { get; set; }
        public string Inuse { get; set; }
        public string Tablenm { get; set; }
        public string Colname { get; set; }
        public int? Fmtype { get; set; }
    }
}
