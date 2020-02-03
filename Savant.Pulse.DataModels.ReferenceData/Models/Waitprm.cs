using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Waitprm
    {
        public string Proctype { get; set; }
        public int Strtday { get; set; }
        public int Endday { get; set; }
        public string Procord { get; set; }
        public int? Dnperslt { get; set; }
        public string Commscd { get; set; }
        public string Comcatcd { get; set; }
        public string Confmail { get; set; }
        public int? Cmdaylim { get; set; }
    }
}
