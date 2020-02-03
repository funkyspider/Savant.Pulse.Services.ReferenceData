using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
