﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Nggrconv
    {
        [Key, Column(Order = 0)] 
        public string Osnatgrd { get; set; }
        public int? Eastofst { get; set; }
        public int? Nrthofst { get; set; }
    }
}
