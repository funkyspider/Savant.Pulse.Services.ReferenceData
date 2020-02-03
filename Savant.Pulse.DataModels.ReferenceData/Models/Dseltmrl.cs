using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Dseltmrl
    {
        [Key, Column(Order = 0)] 
        public string Dnsltmcd { get; set; }
        [Key, Column(Order = 1)] 
        public int Dnslrule { get; set; }
        [Key, Column(Order = 2)] 
        public string Dnkeywrd { get; set; }
        public string Selcon1 { get; set; }
        public string Selval1 { get; set; }
        public string Selcon2 { get; set; }
        public string Selval2 { get; set; }
        public string Selcon3 { get; set; }
        public string Selval3 { get; set; }
        public string Sqlorder { get; set; }
        public string Exisrate { get; set; }
        public string Enrlrate { get; set; }
        public string Usepool { get; set; }
    }
}
