using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Emaildet
    {
        public string Commscd { get; set; }
        public string Langcode { get; set; }
        public string Htmlfile { get; set; }
        public string Inuse { get; set; }
    }
}
