using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mrgprfxs
    {
        [Key, Column(Order = 0)] 
        public string Prefix { get; set; }
        public int? Mxdupcnt { get; set; }
        public int? Mxsrchtm { get; set; }
    }
}
