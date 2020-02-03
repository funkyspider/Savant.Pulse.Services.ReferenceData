using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Holddept
    {
        [Key, Column(Order = 0)] 
        public string Rshcd { get; set; }
        [Key, Column(Order = 1)] 
        public string Rshty { get; set; }
        [Key, Column(Order = 2)] 
        public string Deptcode { get; set; }
        [Key, Column(Order = 3)] 
        public string Sitcd { get; set; }
        [Key, Column(Order = 4)] 
        public string Actavail { get; set; }
    }
}
