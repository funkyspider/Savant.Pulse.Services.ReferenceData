using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Labelfit
    {
        [Key, Column(Order = 0)] 
        public int Fontsize { get; set; }
        [Key, Column(Order = 1)] 
        public int Maxlen { get; set; }
        [Key, Column(Order = 2)] 
        public string Labelstr { get; set; }
        public int? Strfit { get; set; }
    }
}
