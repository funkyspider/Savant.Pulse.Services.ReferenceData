using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrfsec
    {
        [Key, Column(Order = 0)] 
        public string Sectncd { get; set; }
        [Key, Column(Order = 1)] 
        public int Sectnord { get; set; }
        public string Sectntyp { get; set; }
        public string Sectnopt { get; set; }
    }
}
