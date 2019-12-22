using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pcktyp
    {
        public string Pckcod { get; set; }
        public string Pckdes { get; set; }
        public string Inuse { get; set; }
        public string Pckdesw { get; set; }
        public string Rsrvcode { get; set; }
        public int? Codeprio { get; set; }
    }
}
