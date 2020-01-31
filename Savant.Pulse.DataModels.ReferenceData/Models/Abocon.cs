using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Abocon
    {
        [Key, Column(Order = 0)]
        public string Code { get; set; }
        public string Abogr { get; set; }
    }
}
