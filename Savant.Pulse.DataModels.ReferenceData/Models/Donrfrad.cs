using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrfrad
    {
        [Key, Column(Order = 0)] 
        public string Radcode { get; set; }
        [Key, Column(Order = 1)] 
        public int Radord { get; set; }
        public string Radtext { get; set; }
        public string Radcapt { get; set; }
        public string Formatcd { get; set; }
        public string Sectncd { get; set; }
    }
}
