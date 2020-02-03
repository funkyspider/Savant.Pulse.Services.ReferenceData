using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Recrcat
    {
        [Key, Column(Order = 0)] 
        public string Rcrcatcd { get; set; }
        public string Catdesc { get; set; }
    }
}
