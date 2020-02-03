using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Emaildet
    {
        [Key, Column(Order = 0)] 
        public string Commscd { get; set; }
        [Key, Column(Order = 1)] 
        public string Langcode { get; set; }
        public string Htmlfile { get; set; }
        public string Inuse { get; set; }
    }
}
