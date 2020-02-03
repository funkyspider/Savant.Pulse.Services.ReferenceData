using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scialocn
    {
        public string Sesinsat { get; set; }
        public string Comchncd { get; set; }
        public string Doclocn { get; set; }
    }
}
