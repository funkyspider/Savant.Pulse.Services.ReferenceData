﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Procsub
    {
        [Key, Column(Order = 0)] 
        public string Mastproc { get; set; }
        public string Subproc { get; set; }
    }
}
