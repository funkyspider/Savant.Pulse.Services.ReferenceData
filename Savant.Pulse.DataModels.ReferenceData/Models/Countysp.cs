using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Countysp
    {
        [Key, Column(Order = 0)] 
        public string County { get; set; }
        public string Reason { get; set; }
    }
}
