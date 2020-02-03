using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Arcmodes
    {
        public int Dayno { get; set; }
        public string Strttime { get; set; }
        public string Stoptime { get; set; }
        public string Archmode { get; set; }
        public string Archreas { get; set; }
        public string Arcmnote { get; set; }
    }
}
