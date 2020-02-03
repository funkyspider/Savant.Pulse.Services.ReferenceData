using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Messtext
    {
        [Key, Column(Order = 0)] 
        public string Msgno { get; set; }
        [Key, Column(Order = 0)] 
        public string Seqno { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }
    }
}
