﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Gcselect
    {
        public string Gckeywrd { get; set; }
        public string Gcdesc { get; set; }
        public string Gcinuse { get; set; }
    }
}
