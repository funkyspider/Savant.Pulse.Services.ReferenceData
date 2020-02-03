using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Addtvlnk
    {
        [Key, Column(Order = 0)] 
        public string Addrefcd { get; set; }
        public string Pckcod { get; set; }
    }
}
