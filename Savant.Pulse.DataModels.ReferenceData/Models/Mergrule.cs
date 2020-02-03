using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mergrule
    {
        [Key, Column(Order = 0)] 
        public string Abostat { get; set; }
        [Key, Column(Order = 1)] 
        public string Rhstat { get; set; }
        [Key, Column(Order = 2)] 
        public string Tm1stat { get; set; }
        [Key, Column(Order = 3)] 
        public string Tm2stat { get; set; }
        [Key, Column(Order = 4)] 
        public string Serostat { get; set; }
        [Key, Column(Order = 5)] 
        public string Admnstat { get; set; }
        [Key, Column(Order = 6)] 
        public string Labstat { get; set; }
        public string Mrgreslt { get; set; }
    }
}
