using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scslrlia
    {
        public string Sscmtmcd { get; set; }
        public int Sscmrule { get; set; }
        public string Sesinsat { get; set; }
        public string Sesmsgcd { get; set; }
    }
}
