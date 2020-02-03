using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Pulsrprt
    {
        public string Funcname { get; set; }
        public string Sitcd { get; set; }
        public string Loccd { get; set; }
        public string Netprntr { get; set; }
        public string Emailrpt { get; set; }
    }
}
