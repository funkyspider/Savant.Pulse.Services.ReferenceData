using System;
using System.Collections.Generic;

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
