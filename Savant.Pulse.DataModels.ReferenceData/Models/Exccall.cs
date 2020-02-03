using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Exccall
    {
        [Key, Column(Order = 0)] 
        public int Exccd { get; set; }
        public string Excds { get; set; }
    }
}
