using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Cancreas
    {
        public string Canccd { get; set; }
        public string Cancdesc { get; set; }
        public string Inuse { get; set; }
    }
}
