using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Dttype
    {
        [Key, Column(Order = 0)] 
        public string Dtsyscd { get; set; }
        [Key, Column(Order = 1)] 
        public string Dtincty { get; set; }
        public string Inctyds { get; set; }
        public string Inuse { get; set; }
        public string Valtype { get; set; }
        public int? Prio { get; set; }
        public string Datprmpt { get; set; }
        public string Lrule { get; set; }
    }
}
