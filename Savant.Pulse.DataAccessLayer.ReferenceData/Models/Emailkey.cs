﻿using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Emailkey
    {
        public string Keyword { get; set; }
        public string Keywdesc { get; set; }
        public string Fixordb { get; set; }
        public string Subsys { get; set; }
        public string Dbtable { get; set; }
        public string Dbcolumn { get; set; }
        public int? Dayno { get; set; }
        public string Isdate { get; set; }
        public string Istime { get; set; }
    }
}
