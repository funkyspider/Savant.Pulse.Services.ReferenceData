using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Placegrid
    {
        public int Mapseq { get; set; }
        public string KmRef { get; set; }
        public string DefNam { get; set; }
        public string UcdefNam { get; set; }
        public string TileRef { get; set; }
        public int? LatDeg { get; set; }
        public decimal? LatMin { get; set; }
        public int? LongDeg { get; set; }
        public decimal? LongMin { get; set; }
        public int? North { get; set; }
        public int? East { get; set; }
        public string Gmt { get; set; }
        public string CoCode { get; set; }
        public string County { get; set; }
        public string FullCounty { get; set; }
        public string FCode { get; set; }
        public string EDate { get; set; }
        public string UpdateCo { get; set; }
        public int? Sheet1 { get; set; }
        public int? Sheet2 { get; set; }
        public int? Sheet3 { get; set; }
        public string Ctrycode { get; set; }
    }
}
