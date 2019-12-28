using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Savant.Pulse.DataAccessLayer.ReferenceData;
using Savant.Pulse.DataAccessLayer.ReferenceData.Models;
using Savant.Pulse.WebApi.ReferenceData.Services;


namespace Savant.Pulse.WebApi.ReferenceData.Controllers
{

    public class Request
    {
        public string ClassName { get; set; }
        public string MethodName { get; set; }

        public object[] Parameters { get; set; }
    }



    [Route("api/ReferenceData")]
    [ApiController]
    public class ReferenceDataApiController : ControllerBase
    {

        private readonly PulseReferenceContext _context;
        private readonly ILogger<ReferenceDataApiController> _logger;
        private readonly IReferenceDataService _referenceDataService;
        private readonly IServiceProvider _serviceProvider;

        public ReferenceDataApiController(
            PulseReferenceContext context,
            ILogger<ReferenceDataApiController> logger,
            IServiceProvider serviceProvider,
            IReferenceDataService referenceDataService)
        {
            _context = context;
            _logger = logger;
            _serviceProvider = serviceProvider;
            _referenceDataService = referenceDataService;
        }


        [HttpGet]
        public IEnumerable<Siteprm> Get()
        {
            Request r = new Request
            {
                ClassName = "Savant.Pulse.WebApi.ReferenceData.Services.ReferenceDataService",
                MethodName = "GetSiteprmByKey",
                Parameters = new object[] {"**","AAA","BBB" }

            };

            var svc = ActivatorUtilities.CreateInstance(_serviceProvider, Type.GetType(r.ClassName));

            //string scenario1 = "Savant.Pulse.WebApi.ReferenceData.Services.ReferenceDataService";
            //Type theType = this.GetType().Assembly.GetType(scenario1);
            //var theInstance = (IReferenceDataService)ActivatorUtilities.CreateInstance(theType);


            //Type typeToCall = Type.GetType("Savant.Pulse.WebApi.ReferenceData.Services" + "." + "IReferenceDataService" + "," + "Savant.Pulse.WebApi.ReferenceData");

            //Type me = Type.GetType(this.ToString());

            //me.FindMembers(r.ClassName);

            Type thisType = svc.GetType();
            MethodInfo theMethod = thisType.GetMethod(r.MethodName);
            theMethod.Invoke(svc,r.Parameters);


         //   _referenceDataService.GetSiteprmByKey(null, null, null);

            return _context.Siteprm;
        }

    }
}