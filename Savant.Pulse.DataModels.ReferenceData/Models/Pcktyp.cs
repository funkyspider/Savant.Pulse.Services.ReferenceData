using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pcktyp
    {
        [Key, Column(Order = 0)] 
        public string Pckcod { get; set; }
        public string Pckdes { get; set; }
        public string Inuse { get; set; }
        public string Pckdesw { get; set; }
        public string Rsrvcode { get; set; }
        public int? Codeprio { get; set; }
    }
}
