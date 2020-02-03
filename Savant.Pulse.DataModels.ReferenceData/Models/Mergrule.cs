using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mergrule
    {
        public string Abostat { get; set; }
        public string Rhstat { get; set; }
        public string Tm1stat { get; set; }
        public string Tm2stat { get; set; }
        public string Serostat { get; set; }
        public string Admnstat { get; set; }
        public string Labstat { get; set; }
        public string Mrgreslt { get; set; }
    }
}
