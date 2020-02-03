using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Ethcats
    {
        [Key, Column(Order = 0)] 
        public string Ethcatcd { get; set; }
        public string Ethcatds { get; set; }
        public int? Dispord { get; set; }
    }
}
