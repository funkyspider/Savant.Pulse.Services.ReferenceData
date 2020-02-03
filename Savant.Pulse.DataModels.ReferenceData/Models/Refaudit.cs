using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Refaudit
    {
        [Key, Column(Order = 0)] 
        public string Reftblnm { get; set; }
        [Key, Column(Order = 1)] 
        public string Auddate { get; set; }
        [Key, Column(Order = 2)] 
        public string Audtime { get; set; }
        [Key, Column(Order = 3)] 
        public string Chngtype { get; set; }
        [Key, Column(Order = 4)] 
        public string Userid { get; set; }
        [Key, Column(Order = 5)] 
        public int Seq { get; set; }
        public string Databef { get; set; }
        public string Dataaft { get; set; }
    }
}
