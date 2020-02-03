using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mailins
    {
        public string Inscode { get; set; }
        public string Insdesc { get; set; }
        public string Inuse { get; set; }
        public int? Prio { get; set; }
    }
}
