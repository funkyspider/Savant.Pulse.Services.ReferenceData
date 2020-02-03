using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Helphnts
    {
        [Key, Column(Order = 0)] 
        public string Reftblnm { get; set; }
        [Key, Column(Order = 1)] 
        public string Reftblcd { get; set; }
        public string Hinttext { get; set; }
    }
}
