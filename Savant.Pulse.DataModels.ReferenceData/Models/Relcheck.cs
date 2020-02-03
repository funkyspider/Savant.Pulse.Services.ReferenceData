using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Relcheck
    {
        public string Panno { get; set; }
        public string Aborh { get; set; }
        public string Relfct { get; set; }
        public int? Numdays { get; set; }
    }
}
