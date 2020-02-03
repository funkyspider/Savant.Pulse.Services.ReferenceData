using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comsetrf
    {
        [Key, Column(Order = 0)] 
        public string Comvalue { get; set; }
        public string Desc { get; set; }
        public string Inuse { get; set; }
        public string Comcatcd { get; set; }
    }
}
