using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class L62ref
    {
        public string Sitcd { get; set; }
        public string Bchcd { get; set; }
        public int? Row { get; set; }
        public int? Column { get; set; }
        public string Prlabel { get; set; }
    }
}
