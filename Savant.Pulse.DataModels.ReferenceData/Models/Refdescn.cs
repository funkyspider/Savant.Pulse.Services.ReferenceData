using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Refdescn
    {
        public string Reftblnm { get; set; }
        public string Colname { get; set; }
        public string Usertext { get; set; }
    }
}
