using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Rpttxt
    {
        [Key, Column(Order = 0)] 
        public string Mnemonic { get; set; }
        [Key, Column(Order = 1)] 
        public string Rident { get; set; }
        [Key, Column(Order = 2)] 
        public string Rtxtid { get; set; }
        public string Rtxt { get; set; }
    }
}
