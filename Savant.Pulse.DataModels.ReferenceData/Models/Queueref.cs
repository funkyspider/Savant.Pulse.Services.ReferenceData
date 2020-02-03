using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Queueref
    {
        [Key, Column(Order = 0)] 
        public string Jobname { get; set; }
        [Key, Column(Order = 1)] 
        public string Centre { get; set; }
        public string Queuenam { get; set; }
        public int? Qprio { get; set; }
        public string Runame { get; set; }
        public string Runtime { get; set; }
    }
}
