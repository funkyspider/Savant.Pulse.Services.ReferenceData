using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Booklimt
    {
        [Key, Column(Order = 0)] 
        public string Type { get; set; }
        [Key, Column(Order = 1)] 
        public string Code { get; set; }
        [Key, Column(Order = 2)] 
        public string Strtdate { get; set; }
        [Key, Column(Order = 3)] 
        public string Enddate { get; set; }
        public int? Limit { get; set; }
    }
}
