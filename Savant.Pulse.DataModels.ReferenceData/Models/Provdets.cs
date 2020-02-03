using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Provdets
    {
        [Key, Column(Order = 0)] 
        public string Prvider { get; set; }
        public string Prvdesc { get; set; }
        public string Inuse { get; set; }
        public string Destaddr { get; set; }
        public string Destdir { get; set; }
        public string Ftpuser { get; set; }
        public string Ftppass { get; set; }
        public string Ftpdtype { get; set; }
        public string Ftpact { get; set; }
    }
}
