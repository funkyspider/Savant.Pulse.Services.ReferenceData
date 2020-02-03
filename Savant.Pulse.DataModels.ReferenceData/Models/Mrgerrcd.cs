using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mrgerrcd
    {
        [Key, Column(Order = 0)] 
        public string Mrgchkcd { get; set; }
        public string Mrgchkds { get; set; }
    }
}
