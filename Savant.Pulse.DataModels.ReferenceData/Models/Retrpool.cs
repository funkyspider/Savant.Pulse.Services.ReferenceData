using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Retrpool
    {
        public string Centre { get; set; }
        public string Sitcd { get; set; }
        public string Retrstat { get; set; }
    }
}
