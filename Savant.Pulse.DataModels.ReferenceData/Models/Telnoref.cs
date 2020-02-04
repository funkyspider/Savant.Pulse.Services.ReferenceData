using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Telnoref
    {
        [Key, Column(Order = 0)] 
        public string Telnprfx { get; set; }
        public string Status { get; set; }
        public string Teltext { get; set; }
        public string Cnvtelno { get; set; }
        public int? Tellen { get; set; }
    }
}
