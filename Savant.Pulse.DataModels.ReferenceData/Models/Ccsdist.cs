using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Ccsdist
    {
        [Key, Column(Order = 0)] 
        public int Initial { get; set; }
        public int? Increm { get; set; }
    }
}
