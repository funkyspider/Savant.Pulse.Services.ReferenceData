using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Usremail
    {
        [Key, Column(Order = 0)] 
        public string Userid { get; set; }
        [Key, Column(Order = 1)] 
        public string Mnemonic { get; set; }
        public string Emailadd { get; set; }
    }
}
