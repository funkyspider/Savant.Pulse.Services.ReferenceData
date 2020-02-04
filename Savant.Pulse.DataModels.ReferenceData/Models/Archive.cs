using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Archive
    {
        [Key, Column(Order = 0)] 
        public string Keyword { get; set; }
        public string Param { get; set; }
    }
}
