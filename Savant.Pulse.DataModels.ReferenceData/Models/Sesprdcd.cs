using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sesprdcd
    {
        public string Proccode { get; set; }
        public string Pckcod { get; set; }
        public string Option { get; set; }
        public string Prdcd { get; set; }
        public string Packno { get; set; }
    }
}
