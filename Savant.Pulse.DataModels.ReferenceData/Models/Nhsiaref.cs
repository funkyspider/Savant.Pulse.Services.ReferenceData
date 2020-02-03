using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Nhsiaref
    {
        public string Modnam { get; set; }
        public string Code { get; set; }
        public string Data { get; set; }
    }
}
