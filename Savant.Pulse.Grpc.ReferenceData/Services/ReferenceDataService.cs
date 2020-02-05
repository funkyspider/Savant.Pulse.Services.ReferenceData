using Grpc.Core;
using Microsoft.Extensions.Logging;
using Savant.Pulse.DataAccessLayer.ReferenceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Savant.Pulse.Grpc.ReferenceData.ReferenceData;

namespace Savant.Pulse.Grpc.ReferenceData.Services
{
    public class ReferenceDataService : ReferenceDataBase
    {


        private readonly PulseReferenceContext _context;
        private readonly ILogger<ReferenceDataService> _logger;

        public ReferenceDataService(PulseReferenceContext context, ILogger<ReferenceDataService> logger)
        {
            _context = context;
            _logger = logger;
        }


        public override Task<SiteParameterReply> GetSiteParameters(SiteParameterRequest request, ServerCallContext context)
        {
            var siteprmResults = _context.Siteprm.Where(x => x.Sitcd == request.Sitcd && x.Key1 == request.Key1);

            SiteParameterReply response = new SiteParameterReply();

            foreach (var item in siteprmResults)
            {
                response.Items.Add(
                    new SiteParameter
                    {
                        Sitcd = item.Sitcd,
                        Key1 = item.Key1,
                        Key2 = item.Key2,
                        Param = item.Param,
                        Version = item.Version,
                        Desc = item.Desc
                    });
            }

            return Task.FromResult(response);
        }
    }
}
