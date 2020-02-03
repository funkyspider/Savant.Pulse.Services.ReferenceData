using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Reprtout
    {
        public string Funcname { get; set; }
        public string Ident1 { get; set; }
        public string Value1 { get; set; }
        public string Ident2 { get; set; }
        public string Value2 { get; set; }
        public string Ident3 { get; set; }
        public string Value3 { get; set; }
        public string Printer { get; set; }
        public string Email { get; set; }
    }
}
