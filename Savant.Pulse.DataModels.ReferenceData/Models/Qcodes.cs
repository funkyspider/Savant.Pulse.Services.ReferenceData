using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Qcodes
    {
        public string Qcode { get; set; }
        public string Qdesc { get; set; }
    }
}
