using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrffrm
    {
        [Key, Column(Order = 0)] 
        public string Formatcd { get; set; }
        public string Font { get; set; }
        public int? Textsize { get; set; }
        public string Colourcd { get; set; }
        public string Isbold { get; set; }
        public string Isitalic { get; set; }
        public string Isunderl { get; set; }
    }
}
