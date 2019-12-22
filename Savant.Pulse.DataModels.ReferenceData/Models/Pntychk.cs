using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pntychk
    {
        public string Pntycd { get; set; }
        public string Valvals { get; set; }
        public int? Daycount { get; set; }
        public string Daydir { get; set; }
    }
}
