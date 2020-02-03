using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrfprp
    {
        [Key, Column(Order = 0)] 
        public string Promptcd { get; set; }
        public string Prptext { get; set; }
        public string Formatcd { get; set; }
    }
}
