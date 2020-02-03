using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Audevent
    {
        public string Auditcd { get; set; }
        public string Auditds { get; set; }
        public string Auditdsl { get; set; }
        public string Auditdsw { get; set; }
    }
}
