using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Defgrid
    {
        [Key, Column(Order = 0)] 
        public string Keyval { get; set; }
        [Key, Column(Order = 1)] 
        public string Sesdate { get; set; }
        [Key, Column(Order = 2)] 
        public string Gridtype { get; set; }
        [Key, Column(Order = 3)] 
        public string Pertype { get; set; }
        [Key, Column(Order = 4)] 
        public string Daysect { get; set; }
        [Key, Column(Order = 5)] 
        public int Numbeds { get; set; }
        [Key, Column(Order = 6)] 
        public string Gridsect { get; set; }
        [Key, Column(Order = 7)] 
        public int Timeoff { get; set; }
        [Key, Column(Order = 8)] 
        public int Slotno { get; set; }
        public int? Sltlngth { get; set; }
        public string Slottype { get; set; }
        public string Proccode { get; set; }
        public string Apporrep { get; set; }
        public int? Minslots { get; set; }
        public string Dateupd { get; set; }
        public string Timeupd { get; set; }
    }
}
