using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Defgrid
    {
        public string Keyval { get; set; }
        public string Sesdate { get; set; }
        public string Gridtype { get; set; }
        public string Pertype { get; set; }
        public string Daysect { get; set; }
        public int Numbeds { get; set; }
        public string Gridsect { get; set; }
        public int Timeoff { get; set; }
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
