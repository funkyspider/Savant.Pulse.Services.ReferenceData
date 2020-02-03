using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scmessge
    {
        public string Sesmsgcd { get; set; }
        public string Comchncd { get; set; }
        public string Inuse { get; set; }
        public string Messtext { get; set; }
    }
}
