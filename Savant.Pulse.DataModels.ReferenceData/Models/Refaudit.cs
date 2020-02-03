using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Refaudit
    {
        public string Reftblnm { get; set; }
        public string Auddate { get; set; }
        public string Audtime { get; set; }
        public string Chngtype { get; set; }
        public string Userid { get; set; }
        public int Seq { get; set; }
        public string Databef { get; set; }
        public string Dataaft { get; set; }
    }
}
