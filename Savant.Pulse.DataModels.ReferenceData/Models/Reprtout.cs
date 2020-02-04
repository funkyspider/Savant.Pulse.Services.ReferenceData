using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Reprtout
    {
        [Key, Column(Order = 0)] 
        public string Funcname { get; set; }
        [Key, Column(Order = 1)] 
        public string Ident1 { get; set; }
        [Key, Column(Order = 2)] 
        public string Value1 { get; set; }
        [Key, Column(Order = 3)] 
        public string Ident2 { get; set; }
        [Key, Column(Order = 4)] 
        public string Value2 { get; set; }
        [Key, Column(Order = 5)]
        public string Ident3 { get; set; }
        [Key, Column(Order = 6)] 
        public string Value3 { get; set; }
        public string Printer { get; set; }
        public string Email { get; set; }
    }
}
