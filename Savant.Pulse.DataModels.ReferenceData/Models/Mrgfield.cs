﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mrgfield
    {
        [Key, Column(Order = 0)] 
        public string Donfield { get; set; }
        public string Fielddsc { get; set; }
        public string Inuse { get; set; }
        public string Tablenm { get; set; }
        public string Colname { get; set; }
        public int? Fmtype { get; set; }
    }
}
