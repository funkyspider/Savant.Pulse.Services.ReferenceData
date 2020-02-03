using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Gcselect
    {
        [Key, Column(Order = 0)] 
        public string Gckeywrd { get; set; }
        [Key, Column(Order = 1)] 
        public string Gcdesc { get; set; }
        [Key, Column(Order = 2)] 
        public string Gcinuse { get; set; }
    }
}
