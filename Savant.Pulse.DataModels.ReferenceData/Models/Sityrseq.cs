using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sityrseq
    {
        [Key, Column(Order = 0)] 
        public string Identkey { get; set; }
        [Key, Column(Order = 1)] 
        public string Sitcd { get; set; }
        [Key, Column(Order = 2)] 
        public string Yearno { get; set; }
        public int? Nextseq { get; set; }
    }
}
