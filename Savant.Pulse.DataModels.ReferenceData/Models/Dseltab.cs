using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Dseltab
    {
        [Key, Column(Order = 0)] 
        public string Tabname { get; set; }
        public string Inuse { get; set; }
    }
}
