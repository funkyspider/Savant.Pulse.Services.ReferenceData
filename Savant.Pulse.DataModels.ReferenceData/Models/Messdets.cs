using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Messdets
    {
        [Key, Column(Order = 0)] 
        public string Msgno { get; set; }
        [Key, Column(Order = 1)] 
        public string Mnemonic { get; set; }
        [Key, Column(Order = 2)] 
        public string Langcode { get; set; }
        public string Msgtext { get; set; }
        public string Tecdets { get; set; }
        public string Inuse { get; set; }
    }
}
