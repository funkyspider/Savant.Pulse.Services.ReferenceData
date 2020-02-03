using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrftyp
    {
        public string Rftypcd { get; set; }
        public string Rftypds { get; set; }
        public int? Ordnum { get; set; }
        public string Inuse { get; set; }
        public string Emailadd { get; set; }
        public string Emailado { get; set; }
        public string Seccoddi { get; set; }
        public string Seccoddo { get; set; }
        public string Seccodni { get; set; }
        public string Seccodno { get; set; }
        public string Nonuse { get; set; }
    }
}
