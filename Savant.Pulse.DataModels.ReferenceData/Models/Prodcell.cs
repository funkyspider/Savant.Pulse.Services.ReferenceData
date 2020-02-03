using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Prodcell
    {
        [Key, Column(Order = 0)] 
        public string Sitcd { get; set; }
        [Key, Column(Order = 1)] 
        public string Prcellcd { get; set; }
        public string Prcellds { get; set; }
        public string Inuse { get; set; }
    }
}
