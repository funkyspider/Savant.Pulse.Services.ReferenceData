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
    public class WeightbgController : BaseOdataController
    {


        public WeightbgController(
            PulseReferenceContext context,
            ILogger<ReferenceDataApiController> logger) : base(context,logger)
        {
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<Weightbg> Get()
        {
            var sp = _context.Weightbg;
            return sp;
        }
    }
}
