using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Rpttxt
    {
        public string Mnemonic { get; set; }
        public string Rident { get; set; }
        public string Rtxtid { get; set; }
        public string Rtxt { get; set; }
    }
}
