using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Labelfit
    {
        public int Fontsize { get; set; }
        public int Maxlen { get; set; }
        public string Labelstr { get; set; }
        public int? Strfit { get; set; }
    }
}
