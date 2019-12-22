using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Quename
    {
        public string Quename1 { get; set; }
        public string Server { get; set; }
        public int? Joblimit { get; set; }
        public string Questarted { get; set; }
        public string Retryque { get; set; }
    }
}
