using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comscat
    {
        public string Comcatcd { get; set; }
        public string Comcatds { get; set; }
        public string Inuse { get; set; }
        public int? Relprio { get; set; }
    }
}
