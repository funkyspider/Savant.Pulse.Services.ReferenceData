using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Ptypbch
    {
        public string Pckcod { get; set; }
        public string Bchcd { get; set; }
        public string Reslt { get; set; }
        public string Reseval { get; set; }
        public string Tsource { get; set; }
    }
}
