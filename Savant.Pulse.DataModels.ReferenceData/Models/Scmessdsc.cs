﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Scmessdsc
    {
        [Key, Column(Order = 0)] 
        public string Sesmsgcd { get; set; }
        public string Msgcddes { get; set; }
    }
}
