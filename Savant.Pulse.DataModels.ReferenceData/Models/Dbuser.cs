using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Dbuser
    {
        [Key, Column(Order = 0)] 
        public string Userid { get; set; }
        [Key, Column(Order = 1)] 
        public string Dbnamecd { get; set; }
        public string Userman { get; set; }
    }
}
