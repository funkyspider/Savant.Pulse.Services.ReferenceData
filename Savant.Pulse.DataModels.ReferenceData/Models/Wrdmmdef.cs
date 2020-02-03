using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Wrdmmdef
    {
        public string Commscd { get; set; }
        public int Fieldno { get; set; }
        public string Donfield { get; set; }
        public string Dataform { get; set; }
    }
}
