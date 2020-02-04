using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class S46ref
    {
        [Key, Column(Order = 0)] 
        public string Centre { get; set; }
        [Key, Column(Order = 1)] 
        public int Check { get; set; }
        public string Checkdsc { get; set; }
        public string Inuse { get; set; }
        public int? Chktime { get; set; }
    }
}
