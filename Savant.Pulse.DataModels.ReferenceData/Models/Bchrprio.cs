using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Bchrprio
    {
        public string Userid { get; set; }
        public string Bchcd { get; set; }
        public int? Bldprio { get; set; }
    }
}
