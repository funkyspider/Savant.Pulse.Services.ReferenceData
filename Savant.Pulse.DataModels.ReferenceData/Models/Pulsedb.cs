using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pulsedb
    {
        public string Dbnamecd { get; set; }
        public string Dbnameds { get; set; }
        public string Dbtype { get; set; }
        public string Inuse { get; set; }
    }
}
