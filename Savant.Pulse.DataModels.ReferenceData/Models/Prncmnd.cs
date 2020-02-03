using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Prncmnd
    {
        [Key, Column(Order = 0)] 
        public string Prntype { get; set; }
        [Key, Column(Order = 1)] 
        public string Prnfunc { get; set; }
        [Key, Column(Order = 2)] 
        public int Seq { get; set; }
        public int? Prncode { get; set; }
    }
}
