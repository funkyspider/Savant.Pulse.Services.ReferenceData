using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sesoutcm
    {
        [Key, Column(Order = 0)] 
        public string Outcmcd { get; set; }
        public string Outcmdsl { get; set; }
        public string Outcmdsd { get; set; }
        public string Inuse { get; set; }
        public string Outcmtab { get; set; }
        public string Updtldon { get; set; }
        public string Updcredt { get; set; }
        public string Prcprmpt { get; set; }
        public string Smpprmpt { get; set; }
        public string Hbprmpt { get; set; }
        public string Nbprmpt { get; set; }
        public string Rejtype { get; set; }
        public string Anycmpnt { get; set; }
        public string Hldprmpt { get; set; }
        public string Bioreprt { get; set; }
        public string Outcmbar { get; set; }
        public string Lotprmpt { get; set; }
        public string Volprmpt { get; set; }
        public string Tubprmpt { get; set; }
        public string Insprmpt { get; set; }
        public int? Credits { get; set; }
        public string Relfct { get; set; }
        public string Idcprmpt { get; set; }
    }
}
