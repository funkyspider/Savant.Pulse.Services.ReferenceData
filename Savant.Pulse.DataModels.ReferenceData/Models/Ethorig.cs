using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Ethorig
    {
        public string Ethcd { get; set; }
        public string Ethdesc { get; set; }
        public string Inuse { get; set; }
        public string Ethdescw { get; set; }
        public int? Dispord { get; set; }
        public string Ethcatcd { get; set; }
    }
}
