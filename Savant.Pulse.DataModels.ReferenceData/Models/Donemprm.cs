using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donemprm
    {
        [Key, Column(Order = 0)] 
        public string Proctype { get; set; }
        [Key, Column(Order = 1)] 
        public string Proccode { get; set; }
        [Key, Column(Order = 2)] 
        public string Aborh { get; set; }
        [Key, Column(Order = 3)] 
        public string Mnemonic { get; set; }
        public string Commscd { get; set; }
    }
}
