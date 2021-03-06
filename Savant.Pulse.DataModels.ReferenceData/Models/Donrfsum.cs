﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrfsum
    {
        [Key, Column(Order = 0)] 
        public string Summcode { get; set; }
        public string Summtext { get; set; }
        public string Notfyref { get; set; }
        public string Rshcd { get; set; }
        public string Dsgoutcd { get; set; }
        public string Commscd { get; set; }
        public string Comcatcd { get; set; }
        public string Formatcd { get; set; }
        public string Isdupdon { get; set; }
    }
}
