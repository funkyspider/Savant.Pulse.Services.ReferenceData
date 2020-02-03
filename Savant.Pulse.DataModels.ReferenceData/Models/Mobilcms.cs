using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mobilcms
    {
        [Key, Column(Order = 0)] 
        public string Webapp { get; set; }
        [Key, Column(Order = 1)] 
        public string Code { get; set; }
        public string Severity { get; set; }
        public string Messtext { get; set; }
    }
}
