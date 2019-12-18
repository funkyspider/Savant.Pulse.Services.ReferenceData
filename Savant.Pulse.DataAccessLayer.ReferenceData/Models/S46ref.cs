using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class S46ref
    {
        public string Centre { get; set; }
        public int Check { get; set; }
        public string Checkdsc { get; set; }
        public string Inuse { get; set; }
        public int? Chktime { get; set; }
    }
}
