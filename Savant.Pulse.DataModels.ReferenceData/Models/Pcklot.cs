using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pcklot
    {
        public string Lotno { get; set; }
        public string Pckcod { get; set; }
        public string Datrec { get; set; }
        public string Timrec { get; set; }
        public string Sitcd { get; set; }
        public string Expdat { get; set; }
        public int? Nount { get; set; }
        public string Manuf { get; set; }
        public string Username { get; set; }
        public string Inuse { get; set; }
        public string Packadd { get; set; }
        public string Barctype { get; set; }
    }
}
