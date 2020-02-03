﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donelig
    {
        [Key, Column(Order = 0)] 
        public string Eligcode { get; set; }
        public int? Elignumb { get; set; }
        public string Eligdesc { get; set; }
    }
}
