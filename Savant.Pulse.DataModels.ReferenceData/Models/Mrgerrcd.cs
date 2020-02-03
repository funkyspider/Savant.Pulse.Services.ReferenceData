using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Mrgerrcd
    {
        public string Mrgchkcd { get; set; }
        public string Mrgchkds { get; set; }
    }
}
