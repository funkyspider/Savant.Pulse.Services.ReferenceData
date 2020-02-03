using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sityrseq
    {
        public string Identkey { get; set; }
        public string Sitcd { get; set; }
        public string Yearno { get; set; }
        public int? Nextseq { get; set; }
    }
}
