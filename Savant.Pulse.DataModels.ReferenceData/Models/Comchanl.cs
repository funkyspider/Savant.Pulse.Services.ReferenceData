﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comchanl
    {
        [Key, Column(Order = 0)] 
        public string Comchncd { get; set; }
        public string Comchnds { get; set; }
        public string Comcatcd { get; set; }
        public string Inuse { get; set; }
        public string Rnperiod { get; set; }
        public string Runstart { get; set; }
        public string Runstop { get; set; }
        public string Jobid { get; set; }
        public string Typetext { get; set; }
    }
}
