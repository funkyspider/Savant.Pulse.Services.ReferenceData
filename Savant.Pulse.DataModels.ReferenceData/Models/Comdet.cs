using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comdet
    {
        public string Commscd { get; set; }
        public string Commsds { get; set; }
        public string Commsdsw { get; set; }
        public string Comsyscd { get; set; }
        public string Inuse { get; set; }
        public string Lettmand { get; set; }
        public string Bulkcomm { get; set; }
        public string Dhcreq { get; set; }
        public int? Culldays { get; set; }
        public string Ovrdopt { get; set; }
    }
}
