using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Rptparam
    {
        [Key, Column(Order = 0)] 
        public string Rident { get; set; }
        [Key, Column(Order = 1)] 
        public string Sitcd { get; set; }
        public string Rdesc { get; set; }
        public string Rname { get; set; }
        public string Rtype { get; set; }
        public string Format { get; set; }
        public string Filenm { get; set; }
    }
}
