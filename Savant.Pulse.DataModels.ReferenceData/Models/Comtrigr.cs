using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comtrigr
    {
        [Key, Column(Order = 0)] 
        public string Cmtrgpnt { get; set; }
        [Key, Column(Order = 1)] 
        public string Cntcd { get; set; }
        public string Param { get; set; }
        public string Windesc { get; set; }
        public string Inuse { get; set; }
    }
}
