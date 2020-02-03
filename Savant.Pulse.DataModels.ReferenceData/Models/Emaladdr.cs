using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Emaladdr
    {
        [Key, Column(Order = 0)] 
        public string Userid { get; set; }
        [Key, Column(Order = 1)] 
        public string Centre { get; set; }
        public string Email { get; set; }
    }
}
