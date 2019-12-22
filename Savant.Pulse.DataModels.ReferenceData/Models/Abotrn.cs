using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Abotrn
    {
        [Key()]
        public string Barcd { get; set; }
        public string Abogr { get; set; }
        public string Rhgr { get; set; }
        public string Labelty { get; set; }
    }
}
