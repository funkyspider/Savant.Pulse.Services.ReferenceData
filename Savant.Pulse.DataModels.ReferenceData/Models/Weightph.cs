using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Weightph
    {
        public string Fct126 { get; set; }
        public string Gender { get; set; }
        public int? Weight { get; set; }
    }
}
