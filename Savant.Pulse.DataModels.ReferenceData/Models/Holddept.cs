using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Holddept
    {
        public string Rshcd { get; set; }
        public string Rshty { get; set; }
        public string Deptcode { get; set; }
        public string Sitcd { get; set; }
        public string Actavail { get; set; }
    }
}
