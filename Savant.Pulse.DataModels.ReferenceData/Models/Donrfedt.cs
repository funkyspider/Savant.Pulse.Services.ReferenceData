using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Donrfedt
    {
        public string Edtcode { get; set; }
        public string Edttype { get; set; }
        public string Edtname { get; set; }
        public string Ismand { get; set; }
        public string Showcapt { get; set; }
        public string Edtcapt { get; set; }
        public string Edthint { get; set; }
        public string Valflag { get; set; }
        public string Mandgrp { get; set; }
        public string Formatcd { get; set; }
    }
}
