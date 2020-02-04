using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scslrlia
    {
        [Key, Column(Order = 0)] 
        public string Sscmtmcd { get; set; }
        [Key, Column(Order = 1)] 
        public int Sscmrule { get; set; }
        [Key, Column(Order = 2)] 
        public string Sesinsat { get; set; }
        public string Sesmsgcd { get; set; }
    }
}
