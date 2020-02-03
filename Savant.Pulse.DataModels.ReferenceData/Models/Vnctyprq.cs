using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Vnctyprq
    {
        public string Vnctypcd { get; set; }
        public string Colname { get; set; }
    }
}
