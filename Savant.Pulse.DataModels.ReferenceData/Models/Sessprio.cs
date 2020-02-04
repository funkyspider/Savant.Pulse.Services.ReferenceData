using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sessprio
    {
        [Key, Column(Order = 0)] 
        public string Abogrp { get; set; }
        [Key, Column(Order = 1)] 
        public string Rhgrp { get; set; }
        [Key, Column(Order = 2)] 
        public string Gender { get; set; }
    }
}
