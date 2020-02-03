using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Bldchrpr
    {
        [Key, Column(Order = 0)] 
        public string Bchcd { get; set; }
        [Key, Column(Order = 1)] 
        public string Reslt { get; set; }
        public int? Prior { get; set; }
    }
}
