using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Retrpool
    {
        [Key, Column(Order = 0)] 
        public string Centre { get; set; }
        [Key, Column(Order = 1)] 
        public string Sitcd { get; set; }
        public string Retrstat { get; set; }
    }
}
