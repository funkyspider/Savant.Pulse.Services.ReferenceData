using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Errcode
    {
        [Key, Column(Order = 0)] 
        public string Errcode1 { get; set; }
        public string Errmstyp { get; set; }
        public string Beepset { get; set; }
        public string Errmess { get; set; }
        public string Techmess { get; set; }
        public string Auditcd { get; set; }
        public string Cleartxt { get; set; }
    }
}
