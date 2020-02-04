using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scialocn
    {
        [Key, Column(Order = 0)] 
        public string Sesinsat { get; set; }
        [Key, Column(Order = 1)] 
        public string Comchncd { get; set; }
        public string Doclocn { get; set; }
    }
}
