using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Datacul2
    {
        public string Ptabname { get; set; }
        public string Ctabname { get; set; }
        public string Pcolname { get; set; }
        public string Ccolname { get; set; }
    }
}
