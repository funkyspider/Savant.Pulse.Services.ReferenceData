﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Comsystm
    {
        public string Comsyscd { get; set; }
        public string Comsysds { get; set; }
        public string Inuse { get; set; }
    }
}
