using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Q46cntrl
    {
        public string Centre { get; set; }
        public int Runno { get; set; }
        public string Daydate { get; set; }
        public string Usechktm { get; set; }
    }
}
