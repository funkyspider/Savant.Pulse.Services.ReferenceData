using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sctmslrl
    {
        [Key, Column(Order = 0)] 
        public string Sscmtmcd { get; set; }
        [Key, Column(Order = 1)] 
        public int Sscmrule { get; set; }
        public string Commscd { get; set; }
    }
}
