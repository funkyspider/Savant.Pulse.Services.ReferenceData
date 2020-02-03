using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mthsid
    {
        [Key, Column(Order = 0)] 
        public string Idno { get; set; }
        public string Name { get; set; }
    }
}
