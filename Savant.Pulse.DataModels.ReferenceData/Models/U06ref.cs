﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class U06ref
    {
        public string Sitcd { get; set; }
        public string Fprdcd { get; set; }
        public string Loccd { get; set; }
        public string Tprdcd { get; set; }
    }
}
