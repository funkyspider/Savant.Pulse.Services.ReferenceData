using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrfddl
    {
        [Key, Column(Order = 0)] 
        public string Ddlcode { get; set; }
        [Key, Column(Order = 1)] 
        public int Ddlord { get; set; }
        public string Ddltext { get; set; }
        public string Ddlcapt { get; set; }
        public string Formatcd { get; set; }
        public string Sectncd { get; set; }
    }
}
