using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mthsite
    {
        [Key, Column(Order = 0)] 
        public string Sitcd { get; set; }
        public string Title { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Postcd { get; set; }
        public string Telno { get; set; }
        public string Faxno { get; set; }
        public string Lblabrev { get; set; }
        public string Lbltitle { get; set; }
        public string Abotitl1 { get; set; }
        public string Abotitl2 { get; set; }
        public string Abot128 { get; set; }
        public string Psitcd { get; set; }
        public string Lhsite { get; set; }
        public string Inuse { get; set; }
    }
}
