using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Vennowrk
    {
        [Key, Column(Order = 0)] 
        public string Vencod { get; set; }
        [Key, Column(Order = 1)] 
        public DateTime Nwrkdate { get; set; }
        public string Datetext { get; set; }
    }
}
