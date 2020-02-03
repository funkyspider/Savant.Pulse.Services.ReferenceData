using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pltran
    {
        public string Prdcd { get; set; }
        public string Pltype { get; set; }
        public string Bplpsc { get; set; }
    }
}
