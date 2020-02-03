using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sessrev
    {
        public string Keyword { get; set; }
        public int Keyid { get; set; }
        public string Sessno { get; set; }
        public int Seqno { get; set; }
        public string Dateent { get; set; }
        public string Timeent { get; set; }
        public string Mnemonic { get; set; }
        public string Ackuser { get; set; }
        public string Parstr1 { get; set; }
        public string Parstr2 { get; set; }
        public string Parstr3 { get; set; }
        public string Parstr4 { get; set; }
        public string Parstr5 { get; set; }
    }
}
