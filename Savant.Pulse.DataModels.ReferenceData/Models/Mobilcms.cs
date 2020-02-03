using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mobilcms
    {
        public string Webapp { get; set; }
        public string Code { get; set; }
        public string Severity { get; set; }
        public string Messtext { get; set; }
    }
}
