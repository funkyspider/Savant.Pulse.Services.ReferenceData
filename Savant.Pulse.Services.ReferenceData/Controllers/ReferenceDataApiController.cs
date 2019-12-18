using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Savant.Pulse.DataAccessLayer.ReferenceData;
using Savant.Pulse.DataAccessLayer.ReferenceData.Models;

namespace Savant.Pulse.WebApi.ReferenceData.Controllers
{
    [Route("api/ReferenceData")]
    [ApiController]
    public class ReferenceDataApiController : ControllerBase
    {

        private readonly PulseReferenceContext _context;
        private readonly ILogger<ReferenceDataApiController> _logger;

        public ReferenceDataApiController(
            PulseReferenceContext context,
            ILogger<ReferenceDataApiController> logger)
        {
            _context = context;
            _logger = logger;
        }


        [HttpGet]
        [EnableQuery()]
        public IEnumerable<Abotrn> GetAbotrn()
        {
            return _context.Abotrn;
        }


    }
}