using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Refdescn
    {
        [Key, Column(Order = 0)] 
        public string Reftblnm { get; set; }
        [Key, Column(Order = 1)] 
        public string Colname { get; set; }
        public string Usertext { get; set; }
    }
}
