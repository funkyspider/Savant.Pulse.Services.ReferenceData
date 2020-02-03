using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savant.Pulse.DataAccessLayer.ReferenceData.Models
{
    public partial class Servpo
    {
        public string Sitcd { get; set; }
        public string Scaleid { get; set; }
        public string Protocol { get; set; }
        public string Devind { get; set; }
        public string Deviceid { get; set; }
        public string Datcheck { get; set; }
        public string Timcheck { get; set; }
        public string Userid { get; set; }
        public string Balstat { get; set; }
        public string Failreas { get; set; }
        public string Prcellcd { get; set; }
        public string Linefeed { get; set; }
    }
}
