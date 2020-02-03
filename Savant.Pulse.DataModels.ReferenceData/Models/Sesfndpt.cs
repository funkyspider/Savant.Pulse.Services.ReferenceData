using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sesfndpt
    {
        public int Ruleno { get; set; }
        public string Stype { get; set; }
        public string Menutext { get; set; }
        public string Sestat { get; set; }
        public string Pantypcd { get; set; }
        public string Sestypex { get; set; }
        public string Pcd06use { get; set; }
        public string Nccuse { get; set; }
        public string Portluse { get; set; }
        public string Mapsuse { get; set; }
        public string Mobuse { get; set; }
        public string Dfltflag { get; set; }
    }
}
