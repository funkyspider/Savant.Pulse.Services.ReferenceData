using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Procint
    {
        [Key, Column(Order = 0)] 
        public string Proccod1 { get; set; }
        [Key, Column(Order = 1)] 
        public string Proccod2 { get; set; }
        [Key, Column(Order = 2)] 
        public string Gender { get; set; }
        public int? Interint { get; set; }
    }
}
