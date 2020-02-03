using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sessprm
    {
        public string Keyword { get; set; }
        public int Keyid { get; set; }
        public string Ident1 { get; set; }
        public string Ident2 { get; set; }
        public string Ident3 { get; set; }
        public string Ident4 { get; set; }
        public string Ident5 { get; set; }
        public string Ident6 { get; set; }
        public string Ident7 { get; set; }
        public string Ident8 { get; set; }
        public string Ident9 { get; set; }
        public string Ident10 { get; set; }
        public string Inuse { get; set; }
        public string Addrev { get; set; }
        public string Needsack { get; set; }
        public int? Warnlev { get; set; }
        public string Warndesc { get; set; }
        public string Iddesc { get; set; }
        public int? Dispord { get; set; }
        public string Lastran { get; set; }
    }
}
