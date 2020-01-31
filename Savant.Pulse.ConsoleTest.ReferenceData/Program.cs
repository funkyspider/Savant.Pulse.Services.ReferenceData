using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Savant.Pulse.ConsoleTest.ReferenceData;
using Savant.Pulse.DataAccessLayer.ReferenceData.Models;
using Serialize.Linq.Extensions;
using Serialize.Linq.Serializers;



namespace Serialize.Linq.Examples.RestClient
{
    class Program
    {
        private static readonly List<MediaTypeFormatter> _formatters;
        private static readonly MediaTypeWithQualityHeaderValue _mediaTypeJson;
        private static readonly LoggingHandler _loggingHandler;
        private static readonly HttpClient _httpClient;

        static Program()
        {
            _formatters = new List<MediaTypeFormatter> { new JsonMediaTypeFormatter
            {
                SerializerSettings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects
                }
            }};
            _mediaTypeJson = new MediaTypeWithQualityHeaderValue("application/json");

            _loggingHandler = new LoggingHandler(new HttpClientHandler());

            _httpClient = new HttpClient(_loggingHandler) { BaseAddress = new Uri("http://localhost:44305/") };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(_mediaTypeJson);

        }

        static void Main()
        {
            RunAsync().Wait();
        }

        private static async Task RunAsync()
        {
            var cancellationToken = CancellationToken.None;

            _loggingHandler.IsLoggingEnabled = true;
            try
            {
               // await RunAllSiteprmsAsync(cancellationToken);
                await RunAllSiteprmsForQ04(cancellationToken);
                //await RunAllSiteprmsOfAge100(cancellationToken);
                //await RunAllMaleSiteprms(cancellationToken);
                //await RunAllLivingSiteprms(cancellationToken);

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }

        private static async Task RunAllSiteprmsAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("All siteprm");

            var persons = await GetAllSiteprms(cancellationToken);
            ShowSiteprms(persons);
        }

        private static async Task RunAllSiteprmsForQ04(CancellationToken cancellationToken)
        {
            Console.WriteLine("All Siteprms for PCQ04");
            Expression<Func<Siteprm, bool>> expression = p => p.Key2 == "MTHPCQ04";

            var persons = await QuerySiteprms(expression, cancellationToken);
            ShowSiteprms(persons);
        }

        //private static async Task RunAllSiteprmsOfAge100(CancellationToken cancellationToken)
        //{
        //    Console.WriteLine("All siteprm of Age >= 100");
        //    Expression<Func<Siteprm, bool>> expression = p => p.Age >= 100;

        //    var siteprm = await QuerySiteprms(expression, cancellationToken);
        //    ShowSiteprms(siteprm);
        //}

        //private static async Task RunAllMaleSiteprms(CancellationToken cancellationToken)
        //{
        //    Console.WriteLine("All male siteprm");
        //    Expression<Func<Siteprm, bool>> expression = p => p.Gender == Gender.Male;

        //    var siteprm = await QuerySiteprms(expression, cancellationToken);
        //    ShowSiteprms(siteprm);
        //}

        //private static async Task RunAllLivingSiteprms(CancellationToken cancellationToken)
        //{
        //    Console.WriteLine("All living siteprm");
        //    Expression<Func<Siteprm, bool>> expression = p => p.DeathDate == null;

        //    var siteprm = await QuerySiteprms(expression, cancellationToken);
        //    ShowSiteprms(siteprm);
        //}

        private static async Task<IEnumerable<Siteprm>> GetAllSiteprms(CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync("api/ReferenceData", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IEnumerable<Siteprm>>(_formatters, cancellationToken);
        }

        private static async Task<IEnumerable<Siteprm>> QuerySiteprms(Expression<Func<Siteprm, bool>> query, CancellationToken cancellationToken)
        {

            var serializer = new ExpressionSerializer(new Serialize.Linq.Serializers.JsonSerializer());
            string value = serializer.SerializeText(query);

            var queryNode = query.ToExpressionNode();

            var response = await _httpClient.PostAsync("api/ReferenceData",
                new StringContent(value, System.Text.Encoding.UTF8, "application/json"));

            //var response = await _httpClient.PostAsync("api/ReferenceData", queryNode, _formatters[0], _mediaTypeJson, cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IEnumerable<Siteprm>>(_formatters, cancellationToken);
        }

        private static void ShowSiteprms(IEnumerable<Siteprm> siteprms)
        {
            foreach (var s in siteprms)
                Console.WriteLine($"Key1:{s.Key1} | Key2:{s.Key2} | Param:{s.Param} | Desc: {s.Desc}");
            Console.WriteLine(siteprms.Count());
            Console.WriteLine("--------------------------------------");
        }
    }
}