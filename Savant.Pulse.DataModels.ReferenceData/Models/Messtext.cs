using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Messtext
    {
        public string Msgno { get; set; }
        public string Seqno { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }
    }
}
