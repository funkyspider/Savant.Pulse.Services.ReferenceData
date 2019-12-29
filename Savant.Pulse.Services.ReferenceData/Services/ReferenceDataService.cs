using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Savant.Pulse.DataAccessLayer.ReferenceData;
using Savant.Pulse.DataAccessLayer.ReferenceData.Models;
using Savant.Pulse.DataModels.ReferenceData.Extensions;
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

        public async Task<List<Siteprm>> GetSiteprmByKey(string sitcd, string key1, string key2)
        {

            var keys = _context.FindPrimaryKeyNames(new Siteprm()).ToList();
//            var existingEntity = context.Set<TEntity>().Find(keyValues);

            foreach (var key in keys)
            {

            }

            var predicate = PredicateBuilder.True<Siteprm>();

            if (!string.IsNullOrEmpty(sitcd))
            {
            //    predicate = predicate.And(i => i.Sitcd.ToUpper() == sitcd.ToUpper());
                predicate = predicate.And(i => i.Sitcd.Equals(sitcd) );
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
