using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Lbmrgrle
    {
        [Key, Column(Order = 0)] 
        public string Mergekey { get; set; }
        [Key, Column(Order = 1)] 
        public string Status1 { get; set; }
        [Key, Column(Order = 2)] 
        public string Status2 { get; set; }
        public string Mrgreslt { get; set; }
    }
}
