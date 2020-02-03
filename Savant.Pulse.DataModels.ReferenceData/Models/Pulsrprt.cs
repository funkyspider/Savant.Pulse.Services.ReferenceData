using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pulsrprt
    {
        [Key, Column(Order = 0)] 
        public string Funcname { get; set; }
        [Key, Column(Order = 1)] 
        public string Sitcd { get; set; }
        [Key, Column(Order = 2)] 
        public string Loccd { get; set; }
        public string Netprntr { get; set; }
        public string Emailrpt { get; set; }
    }
}
