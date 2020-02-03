using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Hapostcd
    {
        [Key, Column(Order = 0)] 
        public string Postarea { get; set; }
        [Key, Column(Order = 1)] 
        public string Haarea { get; set; }
        public string Areaname { get; set; }
        public int? Nhsnoreq { get; set; }
    }
}
