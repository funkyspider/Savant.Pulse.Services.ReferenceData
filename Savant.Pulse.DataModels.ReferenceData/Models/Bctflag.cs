using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Bctflag
    {
        [Key, Column(Order = 0)] 
        public string Prdcd { get; set; }
        [Key, Column(Order = 1)] 
        public string Keyword { get; set; }
        public string Flagchar { get; set; }
    }
}
