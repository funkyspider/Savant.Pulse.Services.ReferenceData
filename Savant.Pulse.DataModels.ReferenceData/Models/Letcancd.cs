using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Letcancd
    {
        [Key, Column(Order = 0)] 
        public string Letcancd1 { get; set; }
        public string Candesc { get; set; }
        public string Descript { get; set; }
        public string Usersyst { get; set; }
    }
}
