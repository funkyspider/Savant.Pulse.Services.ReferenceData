using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Awardpre
    {
        public int Nocreds { get; set; }
        public string Awrdin { get; set; }
        public string Credassm { get; set; }
        public string Credcom { get; set; }
    }
}
