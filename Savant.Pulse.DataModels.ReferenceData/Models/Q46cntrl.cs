using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Q46cntrl
    {
        [Key, Column(Order = 0)] 
        public string Centre { get; set; }
        [Key, Column(Order = 1)] 
        public int Runno { get; set; }
        public string Daydate { get; set; }
        public string Usechktm { get; set; }
    }
}
