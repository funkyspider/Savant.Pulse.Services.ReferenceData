using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Nhsiaref
    {
        [Key, Column(Order = 0)] 
        public string Modnam { get; set; }
        [Key, Column(Order = 1)] 
        public string Code { get; set; }
        public string Data { get; set; }
    }
}
