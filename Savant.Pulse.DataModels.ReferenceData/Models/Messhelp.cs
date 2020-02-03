using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Messhelp
    {
        [Key, Column(Order = 0)] 
        public int Msgno { get; set; }
        public string Desc { get; set; }
        public string Windesc { get; set; }
        public string Notes { get; set; }
        public string Allretry { get; set; }
        public string Forcemes { get; set; }
    }
}
