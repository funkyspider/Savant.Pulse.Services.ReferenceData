using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Emaladdr
    {
        public string Userid { get; set; }
        public string Centre { get; set; }
        public string Email { get; set; }
    }
}
