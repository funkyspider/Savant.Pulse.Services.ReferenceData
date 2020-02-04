using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Vnctyprq
    {
        [Key, Column(Order = 0)] 
        public string Vnctypcd { get; set; }
        public string Colname { get; set; }
    }
}
