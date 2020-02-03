using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrfrsp
    {
        public string Rfrspcd { get; set; }
        public string Rfrspds { get; set; }
        public string Inuse { get; set; }
    }
}
