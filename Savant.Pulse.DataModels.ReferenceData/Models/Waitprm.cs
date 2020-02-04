using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Waitprm
    {
        [Key, Column(Order = 0)] 
        public string Proctype { get; set; }
        [Key, Column(Order = 1)] 
        public int Strtday { get; set; }
        [Key, Column(Order = 2)] 
        public int Endday { get; set; }
        public string Procord { get; set; }
        public int? Dnperslt { get; set; }
        public string Commscd { get; set; }
        public string Comcatcd { get; set; }
        public string Confmail { get; set; }
        public int? Cmdaylim { get; set; }
    }
}
