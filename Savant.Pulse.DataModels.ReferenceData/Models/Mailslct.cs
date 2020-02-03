using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mailslct
    {
        [Key, Column(Order = 0)] 
        public string Doccode { get; set; }
        [Key, Column(Order = 1)] 
        public string Doctype { get; set; }
        [Key, Column(Order = 2)] 
        public string Slctcon { get; set; }
    }
}
