using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Arcref
    {
        public string Arcsys { get; set; }
        public string Tabname { get; set; }
        public string Tabtype { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Autocop { get; set; }
        public string Autodel { get; set; }
    }
}
