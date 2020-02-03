using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Fctcon
    {
        [Key, Column(Order = 0)] 
        public string Fct1 { get; set; }
        [Key, Column(Order = 1)] 
        public string Fct2 { get; set; }
        [Key, Column(Order = 2)] 
        public string Fct3 { get; set; }
        [Key, Column(Order = 3)] 
        public string Fct4 { get; set; }
        [Key, Column(Order = 4)] 
        public string Fct5 { get; set; }
        [Key, Column(Order = 5)] 
        public string Fct6 { get; set; }
        public string Fct126a { get; set; }
        public string Fct126 { get; set; }
    }
}
