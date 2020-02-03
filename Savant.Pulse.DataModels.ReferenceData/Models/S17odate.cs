using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class S17odate
    {
        public string Centre { get; set; }
        public string Dow { get; set; }
        public int? Outdate { get; set; }
    }
}
