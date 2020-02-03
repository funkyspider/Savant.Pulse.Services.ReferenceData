using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Weightbg
    {
        public string Abogrp { get; set; }
        public string Rhgrp { get; set; }
        public string Gender { get; set; }
        public int? Weight { get; set; }
    }
}
