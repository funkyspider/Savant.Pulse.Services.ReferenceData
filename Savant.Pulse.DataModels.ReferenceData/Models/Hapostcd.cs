using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Hapostcd
    {
        public string Postarea { get; set; }
        public string Haarea { get; set; }
        public string Areaname { get; set; }
        public int? Nhsnoreq { get; set; }
    }
}
