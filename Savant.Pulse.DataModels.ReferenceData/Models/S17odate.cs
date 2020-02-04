using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class S17odate
    {
        [Key, Column(Order = 0)] 
        public string Centre { get; set; }
        [Key, Column(Order = 1)] 
        public string Dow { get; set; }
        public int? Outdate { get; set; }
    }
}
