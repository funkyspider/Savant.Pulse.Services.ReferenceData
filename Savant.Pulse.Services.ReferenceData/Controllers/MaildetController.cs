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
    public class MaildetController : BaseOdataController
    {


        public MaildetController(
            PulseReferenceContext context,
            ILogger<ReferenceDataApiController> logger) : base(context,logger)
        {
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<Maildet> Get()
        {
            var sp = _context.Maildet;
            return sp;
        }
    }
}
