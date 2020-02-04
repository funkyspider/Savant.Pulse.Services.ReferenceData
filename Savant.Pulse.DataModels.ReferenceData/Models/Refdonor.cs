using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Refdonor
    {
        [Key, Column(Order = 0)] 
        public string Centre { get; set; }
        [Key, Column(Order = 1)] 
        public string Perid { get; set; }
        public string Surnm { get; set; }
        public string Inits { get; set; }
        public string Title { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Addr4 { get; set; }
        public string Postcd { get; set; }
    }
}
