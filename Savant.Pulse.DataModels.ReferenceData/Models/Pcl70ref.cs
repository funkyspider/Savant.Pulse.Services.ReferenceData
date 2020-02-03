using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pcl70ref
    {
        public string Sitcd { get; set; }
        public string Labcd { get; set; }
        public string Bchcd { get; set; }
    }
}
