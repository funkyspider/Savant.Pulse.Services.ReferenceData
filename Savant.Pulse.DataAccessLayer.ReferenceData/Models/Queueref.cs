﻿using System;
using System.Collections.Generic;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Queueref
    {
        public string Jobname { get; set; }
        public string Centre { get; set; }
        public string Queuenam { get; set; }
        public int? Qprio { get; set; }
        public string Runame { get; set; }
        public string Runtime { get; set; }
    }
}
