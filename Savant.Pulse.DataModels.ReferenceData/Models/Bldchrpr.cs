using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Bldchrpr
    {
        public string Bchcd { get; set; }
        public string Reslt { get; set; }
        public int? Prior { get; set; }
    }
}
