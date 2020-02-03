using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Awardpre
    {
        [Key, Column(Order = 0)] 
        public int Nocreds { get; set; }
        [Key, Column(Order = 1)] 
        public string Awrdin { get; set; }
        public string Credassm { get; set; }
        public string Credcom { get; set; }
    }
}
