using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Dseldate
    {
        [Key, Column(Order = 0)] 
        public string Dnsltmcd { get; set; }
        [Key, Column(Order = 1)] 
        public string Strtdate { get; set; }
        [Key, Column(Order = 2)] 
        public string Enddate { get; set; }
        [Key, Column(Order = 3)] 
        public string Pntycd { get; set; }
        [Key, Column(Order = 4)] 
        public string Procsite { get; set; }
    }
}
