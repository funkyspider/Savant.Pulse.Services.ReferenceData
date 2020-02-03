using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comsopt
    {
        [Key, Column(Order = 0)]
        public string Commscd { get; set; }
        [Key, Column(Order = 1)] 
        public string Comchncd { get; set; }
        public string Prvider { get; set; }
        public int? Letprio { get; set; }
        public string Comdelay { get; set; }
    }
}
