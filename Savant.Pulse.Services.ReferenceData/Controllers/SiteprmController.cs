using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Savant.Pulse.DataAccessLayer.ReferenceData;
using Savant.Pulse.DataAccessLayer.ReferenceData.Models;

namespace Savant.Pulse.WebApi.ReferenceData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteprmController : ODataController
    {

        private readonly PulseReferenceContext _context;
        private readonly ILogger<ReferenceDataApiController> _logger;

        public SiteprmController(
            PulseReferenceContext context,
            ILogger<ReferenceDataApiController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<Siteprm> Get()
        {
            var sp = _context.Siteprm;
            return sp;
        }
    }
}