using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Adhoctpl
    {
        [Key, Column(Order = 0)] 
        public string Commscd { get; set; }
        [Key, Column(Order = 1)] 
        public string Comchncd { get; set; }

        [Key, Column(Order = 2)] 
        public string Sitcd { get; set; }
        [Key, Column(Order = 3)] 
        public string Langcode { get; set; }
        public string Tmplfile { get; set; }
    }
}
