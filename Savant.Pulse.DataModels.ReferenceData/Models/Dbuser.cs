using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Dbuser
    {
        public string Userid { get; set; }
        public string Dbnamecd { get; set; }
        public string Userman { get; set; }
    }
}
