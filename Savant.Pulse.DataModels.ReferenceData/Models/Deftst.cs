using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Deftst
    {
        [Key, Column(Order = 0)] 
        public string Bchcd { get; set; }
        [Key, Column(Order = 1)] 
        public string Conflg { get; set; }
        [Key, Column(Order = 2)] 
        public string Treslt { get; set; }
        [Key, Column(Order = 3)]
        public string Dreslt { get; set; }
        [Key, Column(Order = 4)] 
        public string Cntcd { get; set; }
        public int? Noresreq { get; set; }
        public string Newdon { get; set; }
        public string Tstcnt { get; set; }
        public string Mchman { get; set; }
        public string Typcd { get; set; }
        public string Bchtst { get; set; }
        public string Mthno1 { get; set; }
        public string Mthno2 { get; set; }
    }
}
