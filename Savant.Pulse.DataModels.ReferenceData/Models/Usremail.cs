using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Usremail
    {
        public string Userid { get; set; }
        public string Mnemonic { get; set; }
        public string Emailadd { get; set; }
    }
}
