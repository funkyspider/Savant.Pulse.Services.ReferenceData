using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Reftable
    {
        [Key, Column(Order = 0)] 
        public string Reftblnm { get; set; }
        [Key, Column(Order = 1)] 
        public string Userid { get; set; }
        public string Readonly { get; set; }
    }
}
