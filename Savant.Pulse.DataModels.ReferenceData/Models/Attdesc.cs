using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Attdesc
    {
        [Key, Column(Order = 0)] 
        public string Restype { get; set; }
        [Key, Column(Order = 1)] 
        public string Mnemonic { get; set; }
        public string Attdescl { get; set; }
        public string Attdescs { get; set; }
    }
}
