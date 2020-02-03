using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Chntimes
    {
        [Key, Column(Order = 0)] 
        public string Comchncd { get; set; }
        public byte[] Nxtdatim { get; set; }
    }
}
