using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scomtmpl
    {
        [Key, Column(Order = 0)] 
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
