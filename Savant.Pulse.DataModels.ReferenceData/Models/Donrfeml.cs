﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrfeml
    {
        [Key, Column(Order = 0)] 
        public string Rftypcd { get; set; }
        public string Emailadd { get; set; }
    }
}
