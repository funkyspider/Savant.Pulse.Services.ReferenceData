using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sitedmnd
    {
        public string Sitcd { get; set; }
        public string Strtdate { get; set; }
        public string Enddate { get; set; }
        public string Proccode { get; set; }
        public string Gender { get; set; }
        public int? Aposdmd { get; set; }
        public int? Bposdmd { get; set; }
        public int? Oposdmd { get; set; }
        public int? Abposdmd { get; set; }
        public int? Anegdmd { get; set; }
        public int? Bnegdmd { get; set; }
        public int? Onegdmd { get; set; }
        public int? Abnegdmd { get; set; }
        public int? Nbdmd { get; set; }
        public int? Apossup { get; set; }
        public int? Bpossup { get; set; }
        public int? Opossup { get; set; }
        public int? Abpossup { get; set; }
        public int? Anegsup { get; set; }
        public int? Bnegsup { get; set; }
        public int? Onegsup { get; set; }
        public int? Abnegsup { get; set; }
        public int? Nbsup { get; set; }
    }
}
