using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Osdate
    {
        public string Pulsdate { get; set; }
        public int? Dateno { get; set; }
    }
}
