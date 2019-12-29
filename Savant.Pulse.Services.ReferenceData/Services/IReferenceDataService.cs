using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Savant.Pulse.DataAccessLayer.ReferenceData.Models;

namespace Savant.Pulse.WebApi.ReferenceData.Services
{
    public interface IReferenceDataService
    {
        Task<List<Siteprm>> GetSiteprmByKey(string sitcd, string key1, string key2);
    }
}
