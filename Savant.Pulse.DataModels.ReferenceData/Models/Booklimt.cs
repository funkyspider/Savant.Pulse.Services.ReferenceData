using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Booklimt
    {
        public string Type { get; set; }
        public string Code { get; set; }
        public string Strtdate { get; set; }
        public string Enddate { get; set; }
        public int? Limit { get; set; }
    }
}
