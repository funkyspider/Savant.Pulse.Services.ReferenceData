using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Datacull
    {
        [Key, Column(Order = 0)] 
        public string Tabname { get; set; }
        [Key, Column(Order = 1)] 
        public string Keycolmn { get; set; }
        public int? Clperiod { get; set; }
        public string Datetype { get; set; }
        public string Lastdate { get; set; }
        public int? Lastcnt { get; set; }
        public string Lastrun { get; set; }
    }
}
