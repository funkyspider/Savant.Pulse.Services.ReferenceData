using System;
using System.Collections.Generic;

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
