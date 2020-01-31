using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Addrclen
    {
        [Key, Column(Order = 0)]
        public string Ptable { get; set; }
        [Key, Column(Order = 1)]
        public string Pcolumn { get; set; }
        public string Keycol { get; set; }
        public string Keycol2 { get; set; }
        public string Keycol3 { get; set; }
        public string Addr1col { get; set; }
        public string Addr2col { get; set; }
        public string Addr3col { get; set; }
        public string Addr4col { get; set; }
        public string Addr5col { get; set; }
        public string Addr6col { get; set; }
        public string Inusecol { get; set; }
        public string Addrtype { get; set; }
    }
}
