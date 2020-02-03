using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mmfortyp
    {
        public int Fmtype { get; set; }
        public string Fmdesc { get; set; }
    }
}
