using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Ooasuppl
    {
        [Key, Column(Order = 0)] 
        public string Ctrycode { get; set; }
        public string Pstmess1 { get; set; }
        public string Pstmess2 { get; set; }
        public string Pstmess3 { get; set; }
    }
}
