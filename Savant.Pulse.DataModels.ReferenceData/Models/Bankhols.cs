﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Bankhols
    {
        [Key, Column(Order = 0)] 
        public DateTime Holdate { get; set; }
        public string Holdesc { get; set; }
        public string Refinuse { get; set; }
    }
}
