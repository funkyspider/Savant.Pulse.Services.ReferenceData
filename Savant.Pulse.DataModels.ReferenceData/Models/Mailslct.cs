using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mailslct
    {
        public string Doccode { get; set; }
        public string Doctype { get; set; }
        public string Slctcon { get; set; }
    }
}
