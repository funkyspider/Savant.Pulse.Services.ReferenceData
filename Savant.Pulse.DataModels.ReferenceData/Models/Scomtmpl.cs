using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scomtmpl
    {
        public string Sscmtmcd { get; set; }
        public string Sscmtmds { get; set; }
        public string Inuse { get; set; }
        public string Sesmsgcd { get; set; }
        public string Messprio { get; set; }
        public string Comchncd { get; set; }
        public string Donorsel { get; set; }
        public string Sendprio { get; set; }
        public int? Dsptchdt { get; set; }
        public int? Inboxdte { get; set; }
    }
}
