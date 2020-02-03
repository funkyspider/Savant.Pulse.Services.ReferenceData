using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Quename
    {
        [Key, Column(Order = 0)]
        public string Quename1 { get; set; }
        public string Server { get; set; }
        public int? Joblimit { get; set; }
        public string Questarted { get; set; }
        public string Retryque { get; set; }
    }
}
