using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sccmslct
    {
        [Key, Column(Order = 0)] 
        public string Cominscd { get; set; }
        [Key, Column(Order = 1)] 
        public string Cdtype { get; set; }
        [Key, Column(Order = 2)] 
        public string Sckeywrd { get; set; }
    }
}
