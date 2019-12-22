using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Qjobs
    {
        public string Entryid { get; set; }
        public string Jobid { get; set; }
        public DateTime? Jobstart { get; set; }
        public DateTime? Realstart { get; set; }
        public DateTime? Jobend { get; set; }
        public string Userid { get; set; }
        public string Qcode { get; set; }
        public string Quename { get; set; }
        public string Qoverride { get; set; }
        public string Jobdata { get; set; }
        public string Errdata { get; set; }
        public string Errentryid { get; set; }
        public int? Noretry { get; set; }
        public int? Msgid { get; set; }
    }
}
