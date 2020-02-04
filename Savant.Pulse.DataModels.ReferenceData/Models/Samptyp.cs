using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Samptyp
    {
        [Key, Column(Order = 0)] 
        public int Smpindex { get; set; }
        public string Smptypds { get; set; }
        public string Orgdonq { get; set; }
        public string Adddetq { get; set; }
    }
}
