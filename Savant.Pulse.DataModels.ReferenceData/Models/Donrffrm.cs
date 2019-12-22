using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrffrm
    {
        public string Formatcd { get; set; }
        public string Font { get; set; }
        public int? Textsize { get; set; }
        public string Colourcd { get; set; }
        public string Isbold { get; set; }
        public string Isitalic { get; set; }
        public string Isunderl { get; set; }
    }
}
