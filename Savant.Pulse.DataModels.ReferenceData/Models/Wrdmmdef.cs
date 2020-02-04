using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Wrdmmdef
    {
        [Key, Column(Order = 0)] 
        public string Commscd { get; set; }
        [Key, Column(Order = 1)] 
        public int Fieldno { get; set; }
        public string Donfield { get; set; }
        public string Dataform { get; set; }
    }
}
