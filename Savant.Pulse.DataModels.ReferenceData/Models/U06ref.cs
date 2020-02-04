using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class U06ref
    {
        [Key, Column(Order = 0)] 
        public string Sitcd { get; set; }
        [Key, Column(Order = 1)] 
        public string Fprdcd { get; set; }
        public string Loccd { get; set; }
        public string Tprdcd { get; set; }
    }
}
