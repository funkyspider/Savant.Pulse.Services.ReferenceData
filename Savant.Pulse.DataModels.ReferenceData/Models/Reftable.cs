using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Reftable
    {
        public string Reftblnm { get; set; }
        public string Userid { get; set; }
        public string Readonly { get; set; }
    }
}
