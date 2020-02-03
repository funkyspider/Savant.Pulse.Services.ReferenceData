using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Prncmnd
    {
        public string Prntype { get; set; }
        public string Prnfunc { get; set; }
        public int Seq { get; set; }
        public int? Prncode { get; set; }
    }
}
