using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Savant.Pulse.DataAccessLayer.ReferenceData;

namespace Savant.Pulse.WebApi.ReferenceData.Controllers
{
    public class BaseOdataController : ODataController
    {
        protected readonly PulseReferenceContext _context;
        protected readonly ILogger<ReferenceDataApiController> _logger;


        public BaseOdataController(PulseReferenceContext context, ILogger<ReferenceDataApiController> logger)
        {
            this._context = context;
            this._logger = logger;
        }
    }
}