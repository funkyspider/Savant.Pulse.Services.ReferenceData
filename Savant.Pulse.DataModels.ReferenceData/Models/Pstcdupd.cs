using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pstcdupd
    {
        [Key, Column(Order = 0)] 
        public string Ptable { get; set; }
        [Key, Column(Order = 1)] 
        public string Pcolumn { get; set; }
        [Key, Column(Order = 2)] 
        public string Keycol1 { get; set; }
        [Key, Column(Order = 3)] 
        public string Keycol2 { get; set; }
        [Key, Column(Order = 4)] 
        public string Keycol3 { get; set; }
        [Key, Column(Order = 5)] 
        public string Keycol4 { get; set; }
        public string Nongeogp { get; set; }
    }
}
