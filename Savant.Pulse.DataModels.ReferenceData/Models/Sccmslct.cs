using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sccmslct
    {
        public string Cominscd { get; set; }
        public string Cdtype { get; set; }
        public string Sckeywrd { get; set; }
    }
}
