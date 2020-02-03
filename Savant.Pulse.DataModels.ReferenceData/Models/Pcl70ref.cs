using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pcl70ref
    {
        [Key, Column(Order = 0)] 
        public string Sitcd { get; set; }
        [Key, Column(Order = 1)] 
        public string Labcd { get; set; }
        [Key, Column(Order = 3)] 
        public string Bchcd { get; set; }
    }
}
