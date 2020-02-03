using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Siteprm
    {
        [Key, Column(Order = 0)]
        public string Sitcd { get; set; }
        [Key, Column(Order = 1)] 
        public string Key1 { get; set; }
        [Key, Column(Order = 2)] 
        public string Key2 { get; set; }
        public string Param { get; set; }
        public string Version { get; set; }
        public string Desc { get; set; }
    }
}
