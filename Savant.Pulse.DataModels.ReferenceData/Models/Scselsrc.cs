using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scselsrc
    {
        public string Sckeywrd { get; set; }
        public string Menutext { get; set; }
        public string Querytyp { get; set; }
        public int? Selparlm { get; set; }
        public string Tablenm1 { get; set; }
        public string Columnm1 { get; set; }
        public string Datatyp1 { get; set; }
        public string Columnm2 { get; set; }
        public string Datatyp2 { get; set; }
        public string Coleval2 { get; set; }
        public string Columnm3 { get; set; }
        public string Datatyp3 { get; set; }
        public string Coleval3 { get; set; }
        public string Sqlstmnt { get; set; }
        public string Col1text { get; set; }
        public string Col2text { get; set; }
        public string Col3text { get; set; }
    }
}
