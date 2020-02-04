using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Sessproc
    {
        [Key, Column(Order = 0)] 
        public string Proccode { get; set; }
        public string Procdesc { get; set; }
        public string Inuse { get; set; }
        public int? Deftime { get; set; }
        public int? Maxage { get; set; }
        public int? Minage { get; set; }
        public int? Rguqmnag { get; set; }
        public int? Rguqmxag { get; set; }
        public int? Rgq1mxag { get; set; }
        public int? Rgq1nmyr { get; set; }
        public int? Rgq1nmdn { get; set; }
        public int? Rgq2mxag { get; set; }
        public int? Rgq2nmyr { get; set; }
        public int? Rgq2nmdn { get; set; }
        public int? Dnuqmnag { get; set; }
        public int? Dnuqmxag { get; set; }
        public int? Dnq1mxag { get; set; }
        public int? Dnq1nmyr { get; set; }
        public int? Dnq1nmdn { get; set; }
        public string Dnq1xdef { get; set; }
        public string Dnq1xcom { get; set; }
        public string Dnq1odef { get; set; }
        public string Dnq1ocom { get; set; }
        public int? Dnq2mxag { get; set; }
        public int? Dnq2nmyr { get; set; }
        public int? Dnq2nmdn { get; set; }
        public string Dnq2xdef { get; set; }
        public string Dnq2xcom { get; set; }
        public string Dnq2odef { get; set; }
        public string Dnq2ocom { get; set; }
        public int? Pretday { get; set; }
        public string Pretocom { get; set; }
        public string Pretxcom { get; set; }
        public string Expantyp { get; set; }
        public int? Credits { get; set; }
        public string Colcode { get; set; }
        public string Nccdef { get; set; }
        public string Pcdef { get; set; }
        public string Dmdef { get; set; }
        public string Somdef { get; set; }
        public string Proctype { get; set; }
        public string Nccovrd { get; set; }
        public string Nccregnr { get; set; }
    }
}
