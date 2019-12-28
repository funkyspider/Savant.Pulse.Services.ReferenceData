using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Savant.Pulse.WebApi.ReferenceData.Services
{
    public interface IReferenceDataService
    {
        string GetSiteprmByKey(string siteCode, string key1, string key2);
    }
}
