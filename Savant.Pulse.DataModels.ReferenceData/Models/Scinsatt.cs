using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scinsatt
    {
        [Key, Column(Order = 0)] 
        public string Sesinsat { get; set; }
        public string Insatdes { get; set; }
        public string Inuse { get; set; }
    }
}
