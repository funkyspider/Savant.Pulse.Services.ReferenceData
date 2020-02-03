using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Prodcell
    {
        public string Sitcd { get; set; }
        public string Prcellcd { get; set; }
        public string Prcellds { get; set; }
        public string Inuse { get; set; }
    }
}
