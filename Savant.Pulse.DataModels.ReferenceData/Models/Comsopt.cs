using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comsopt
    {
        public string Commscd { get; set; }
        public string Comchncd { get; set; }
        public string Prvider { get; set; }
        public int? Letprio { get; set; }
        public string Comdelay { get; set; }
    }
}
