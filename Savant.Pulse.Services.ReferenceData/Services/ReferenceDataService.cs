using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Savant.Pulse.DataAccessLayer.ReferenceData;
using Savant.Pulse.DataAccessLayer.ReferenceData.Models;
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

        public async Task<List<Siteprm>> GetSiteprmByKey(string siteCode, string key1, string key2)
        {

            var predicate = PredicateBuilder.True<Siteprm>();

            if (!string.IsNullOrEmpty(siteCode))
            {
            //    predicate = predicate.And(i => i.Sitcd.ToUpper() == siteCode.ToUpper());
                predicate = predicate.And(i => i.Sitcd.Equals(siteCode) );
            }

            if (!string.IsNullOrEmpty(key1))
            {
                predicate = predicate.And(i => i.Key1 == key1);
            }

            if (!string.IsNullOrEmpty(key2))
            {
                predicate = predicate.And(i => i.Key2 == key2);
            }

            return await _context.Siteprm. Where(predicate).ToListAsync();
        }
    }
}
