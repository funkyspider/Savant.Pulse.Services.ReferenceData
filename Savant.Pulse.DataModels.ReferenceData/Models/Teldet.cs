using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Teldet
    {
        public string Commscd { get; set; }
        public string Langcode { get; set; }
        public string Gentext { get; set; }
        public string Dontext { get; set; }
        public string Inuse { get; set; }
    }
}
