using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comsysct
    {
        [Key, Column(Order = 0)] 
        public string Comsyscd { get; set; }
        [Key, Column(Order = 1)] 
        public string Comcatcd { get; set; }
    }
}
