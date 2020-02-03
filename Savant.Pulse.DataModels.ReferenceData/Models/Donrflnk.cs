using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrflnk
    {
        public string Rftypcd { get; set; }
        public string Rfrspcd { get; set; }
    }
}
