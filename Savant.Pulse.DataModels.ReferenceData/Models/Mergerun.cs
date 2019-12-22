using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mergerun
    {
        public string Rundate { get; set; }
        public string Mrgrunno { get; set; }
        public string Cntcd { get; set; }
        public string Starttim { get; set; }
        public string Endtim { get; set; }
        public string Matchlev { get; set; }
        public int? Nodonors { get; set; }
        public int? Norecreq { get; set; }
        public int? Norecact { get; set; }
        public int? Norecdup { get; set; }
        public DateTime? Recdate { get; set; }
        public string Recperid { get; set; }
        public int? Noprsreq { get; set; }
        public int? Noprsact { get; set; }
        public int? Noprsdup { get; set; }
        public DateTime? Prsdate { get; set; }
        public string Prsperid { get; set; }
        public string Noactchk { get; set; }
        public string Actperid { get; set; }
        public int? Noactcnt { get; set; }
        public int? Noactdup { get; set; }
        public string Nowthchk { get; set; }
        public string Wthperid { get; set; }
        public int? Nowthcnt { get; set; }
        public int? Nowthdup { get; set; }
    }
}
