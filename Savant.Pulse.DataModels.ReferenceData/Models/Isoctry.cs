using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Isoctry
    {
        [Key, Column(Order = 0)] 
        public string Ctrycode { get; set; }
        public string Ctrydesc { get; set; }
        public string Inuse { get; set; }
        public string Defercd { get; set; }
    }
}
