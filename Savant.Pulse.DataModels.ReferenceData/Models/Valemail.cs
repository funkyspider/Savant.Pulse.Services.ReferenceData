using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Valemail
    {
        public string Emaildmn { get; set; }
        public string Emailtyp { get; set; }
    }
}
