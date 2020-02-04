using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sesprdcd
    {
        [Key, Column(Order = 0)] 
        public string Proccode { get; set; }
        [Key, Column(Order = 1)] 
        public string Pckcod { get; set; }
        [Key, Column(Order = 2)] 
        public string Option { get; set; }
        [Key, Column(Order = 3)] 
        public string Prdcd { get; set; }
        public string Packno { get; set; }
    }
}
