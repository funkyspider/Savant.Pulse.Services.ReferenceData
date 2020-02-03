using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Nmresdsp
    {
        public string Proccode { get; set; }
        public string Bchcd { get; set; }
        public int? Relpos { get; set; }
        public string Inuse { get; set; }
    }
}
