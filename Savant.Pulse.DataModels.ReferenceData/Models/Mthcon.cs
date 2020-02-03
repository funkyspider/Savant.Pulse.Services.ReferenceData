﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mthcon
    {
        [Key, Column(Order = 0)] 
        public string Bchcd { get; set; }
        public string Donat { get; set; }
        public string Dondet { get; set; }
    }
}
