﻿using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Provdets
    {
        public string Prvider { get; set; }
        public string Prvdesc { get; set; }
        public string Inuse { get; set; }
        public string Destaddr { get; set; }
        public string Destdir { get; set; }
        public string Ftpuser { get; set; }
        public string Ftppass { get; set; }
        public string Ftpdtype { get; set; }
        public string Ftpact { get; set; }
    }
}