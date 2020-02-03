using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Deftst
    {
        public string Bchcd { get; set; }
        public string Conflg { get; set; }
        public string Treslt { get; set; }
        public string Dreslt { get; set; }
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
