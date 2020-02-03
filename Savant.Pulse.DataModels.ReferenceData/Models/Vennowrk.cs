using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Vennowrk
    {
        public string Vencod { get; set; }
        public DateTime Nwrkdate { get; set; }
        public string Datetext { get; set; }
    }
}
