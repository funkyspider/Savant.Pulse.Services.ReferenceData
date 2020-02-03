using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Helphnts
    {
        public string Reftblnm { get; set; }
        public string Reftblcd { get; set; }
        public string Hinttext { get; set; }
    }
}
