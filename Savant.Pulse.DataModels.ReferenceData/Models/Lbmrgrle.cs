using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Lbmrgrle
    {
        public string Mergekey { get; set; }
        public string Status1 { get; set; }
        public string Status2 { get; set; }
        public string Mrgreslt { get; set; }
    }
}
