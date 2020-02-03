using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scslrlcn
    {
        public string Sscmtmcd { get; set; }
        public int Sscmrule { get; set; }
        public string Sckeywrd { get; set; }
        public string Selcon1 { get; set; }
        public string Selval1 { get; set; }
        public string Selcon2 { get; set; }
        public string Selval2 { get; set; }
        public string Selcon3 { get; set; }
        public string Selval3 { get; set; }
    }
}
