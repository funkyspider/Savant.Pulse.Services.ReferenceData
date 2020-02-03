using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Attdesc
    {
        public string Restype { get; set; }
        public string Mnemonic { get; set; }
        public string Attdescl { get; set; }
        public string Attdescs { get; set; }
    }
}
