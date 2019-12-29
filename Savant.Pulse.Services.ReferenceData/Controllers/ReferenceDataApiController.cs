using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
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

        public string[] Parameters { get; set; }
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
        public IEnumerable<Object> Get()
        {
            Request r = new Request
            {
                ClassName = "Savant.Pulse.WebApi.ReferenceData.Services.ReferenceDataService",
                MethodName = "GetSiteprmByKey",
                Parameters = new string[] { "**", "GENNARO", "" }
            };

            var svc = ActivatorUtilities.CreateInstance(_serviceProvider, Type.GetType(r.ClassName));

            Type thisType = svc.GetType();
            MethodInfo theMethod = thisType.GetMethod(r.MethodName);
            var s = (theMethod.Invoke(svc, r.Parameters));

            return (IEnumerable<Object>)(s);

        }


        [HttpPost]
        public async Task<string> Generic([FromBody]Request r)
        {

            //     {
            //    "ClassName": "Savant.Pulse.WebApi.ReferenceData.Services.ReferenceDataService",
            //    "MethodName": "GetSiteprmByKey",
            //    "Parameters": [
            //    "",
            //    "GENNARO",
            //    ""
            //        ]
            //}

            // Create instance of class using Dependency Injection provider to inject constructor params into created class instance
            var classInstance = ActivatorUtilities.CreateInstance(_serviceProvider, Type.GetType(r.ClassName));

            // Get class type
            Type type = classInstance.GetType();
            
            // Get reference to method using input parameter
            MethodInfo method = type.GetMethod(r.MethodName);

            // Create a task and run the class.method with the parameters
            var task = (Task)method.Invoke(classInstance, r.Parameters);
            await task.ConfigureAwait(false);
            
            // Get weird task result and get the method response value
            var taskResult = task.GetType().GetProperty("Result");
            var s = taskResult.GetValue(task);


            //var s = method.Invoke(classInstance, r.Parameters);

            string a = JsonSerializer.Serialize(s);
            return a;
        }

    }
}