using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donemprm
    {
        public string Proctype { get; set; }
        public string Proccode { get; set; }
        public string Aborh { get; set; }
        public string Mnemonic { get; set; }
        public string Commscd { get; set; }
    }
}
