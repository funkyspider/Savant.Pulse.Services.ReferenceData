using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Valemail
    {
        [Key, Column(Order = 0)] 
        public string Emaildmn { get; set; }
        [Key, Column(Order = 1)] 
        public string Emailtyp { get; set; }
    }
}
