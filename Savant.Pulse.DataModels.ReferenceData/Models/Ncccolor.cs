using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Ncccolor
    {
        [Key, Column(Order = 0)] 
        public string Nccdate { get; set; }
        [Key, Column(Order = 1)] 
        public string Aborh { get; set; }
        public string Foreclr { get; set; }
        public string Backclr { get; set; }
    }
}
