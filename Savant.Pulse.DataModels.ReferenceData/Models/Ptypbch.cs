using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Ptypbch
    {
        [Key, Column(Order = 0)] 
        public string Pckcod { get; set; }
        [Key, Column(Order = 1)] 
        public string Bchcd { get; set; }
        public string Reslt { get; set; }
        public string Reseval { get; set; }
        public string Tsource { get; set; }
    }
}
