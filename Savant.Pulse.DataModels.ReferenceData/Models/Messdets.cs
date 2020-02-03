using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Messdets
    {
        public string Msgno { get; set; }
        public string Mnemonic { get; set; }
        public string Langcode { get; set; }
        public string Msgtext { get; set; }
        public string Tecdets { get; set; }
        public string Inuse { get; set; }
    }
}
