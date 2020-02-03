using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Manident
    {
        public string Manuf { get; set; }
        public string Manfdesc { get; set; }
        public string Bartype { get; set; }
        public string Inuse { get; set; }
    }
}
