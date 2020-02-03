using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Jobname
    {
        public string Jobid { get; set; }
        public string Jobname1 { get; set; }
        public int? Increment { get; set; }
        public string Unit { get; set; }
        public string Permanent { get; set; }
        public string Dayfilter { get; set; }
        public string Retryfail { get; set; }
        public string Quename { get; set; }
        public string Xmldata { get; set; }
        public int? Maxretry { get; set; }
        public string Comid { get; set; }
    }
}
