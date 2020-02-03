using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Namevar
    {
        [Key, Column(Order = 0)] 
        public int Varnum { get; set; }
        public string Varname { get; set; }
    }
}
