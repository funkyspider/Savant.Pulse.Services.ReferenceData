using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mrktdept
    {
        [Key, Column(Order = 0)] 
        public string Mrktcode { get; set; }
        public string Mrktdesc { get; set; }
        public string Inuse { get; set; }
    }
}
