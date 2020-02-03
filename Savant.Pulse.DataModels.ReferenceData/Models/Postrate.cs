using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Postrate
    {
        [Key, Column(Order = 0)] 
        public string Ratecd { get; set; }
        public string Ratedsc { get; set; }
    }
}
