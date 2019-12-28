using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Savant.Pulse.DataAccessLayer.ReferenceData;
using Savant.Pulse.WebApi.ReferenceData.Controllers;

namespace Savant.Pulse.WebApi.ReferenceData.Services
{
    public class ReferenceDataService : IReferenceDataService
    {

        private readonly PulseReferenceContext _context;
        private readonly ILogger<ReferenceDataApiController> _logger;

        public ReferenceDataService(PulseReferenceContext context, ILogger<ReferenceDataApiController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public string GetSiteprmByKey(string siteCode, string key1, string key2)
        {
            throw new NotImplementedException();
        }
    }
}
