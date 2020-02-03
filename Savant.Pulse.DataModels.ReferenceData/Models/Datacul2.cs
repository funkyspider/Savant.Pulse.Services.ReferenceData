using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Datacul2
    {
        [Key, Column(Order = 0)] 
        public string Ptabname { get; set; }
        [Key, Column(Order = 1)] 
        public string Ctabname { get; set; }
        public string Pcolname { get; set; }
        public string Ccolname { get; set; }
    }
}
