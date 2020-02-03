using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Procint
    {
        public string Proccod1 { get; set; }
        public string Proccod2 { get; set; }
        public string Gender { get; set; }
        public int? Interint { get; set; }
    }
}
