using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comdfpln
    {
        [Key, Column(Order = 0)] 
        public DateTime Strtdate { get; set; }
        [Key, Column(Order = 1)] 
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
