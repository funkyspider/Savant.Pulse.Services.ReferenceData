using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Awardcon
    {
        [Key, Column(Order = 0)] 
        public string Awrdcond { get; set; }
        public string Awrdinst { get; set; }
        public string Condescl { get; set; }
        public string Condescs { get; set; }
        public string Usercond { get; set; }
    }
}
