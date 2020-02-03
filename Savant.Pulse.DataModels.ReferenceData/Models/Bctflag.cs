using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Bctflag
    {
        public string Prdcd { get; set; }
        public string Keyword { get; set; }
        public string Flagchar { get; set; }
    }
}
