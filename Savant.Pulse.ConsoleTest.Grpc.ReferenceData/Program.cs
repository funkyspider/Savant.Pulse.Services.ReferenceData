using Grpc.Net.Client;
using Savant.Pulse.Grpc.ReferenceData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using static Savant.Pulse.Grpc.ReferenceData.ReferenceData;

namespace Savant.Pulse.ConsoleTest.Grpc.ReferenceData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            RunAsync().Wait();
        }

        private static async Task RunAsync()
        {
            var cancellationToken = CancellationToken.None;

            try
            {
                StartTasks(10, cancellationToken);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }


        private static void StartTasks(int taskCount, CancellationToken cancellationToken)
        {

            List<Task> taskArray = new List<Task>();

            for (int i = 0; i < taskCount; i++)
            {
                taskArray.Add(LoadSessionManagementReferenceDataUsingGrpc(i, cancellationToken));
            }

            Stopwatch st = new Stopwatch();
            st.Start();

            Task.WaitAll(taskArray.ToArray());

            st.Stop();

            Console.WriteLine(st.Elapsed);

            Console.WriteLine("Finished");
            Console.ReadKey();

        }


        private static async Task LoadSessionManagementReferenceDataUsingGrpc(int i, CancellationToken cancellationToken)
        {
            Stopwatch st = new Stopwatch();

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter($@"C:\Temp\Grpc_{i}.txt"))

            {
                file.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff tt"));
                st.Start();

                var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new ReferenceDataClient(channel);

                SiteParameterReply response;

                response = await client.GetSiteParametersAsync(new Pulse.Grpc.ReferenceData.SiteParameterRequest { Sitcd = "**", Key1 = "MTHPCD63", Key2 = "" });
                response = await client.GetSiteParametersAsync(new Pulse.Grpc.ReferenceData.SiteParameterRequest { Sitcd = "**", Key1 = "SESSION", Key2 = "" });
                response = await client.GetSiteParametersAsync(new Pulse.Grpc.ReferenceData.SiteParameterRequest { Sitcd = "**", Key1 = "DONOR_COMMS", Key2 = "" });
                response = await client.GetSiteParametersAsync(new Pulse.Grpc.ReferenceData.SiteParameterRequest { Sitcd = "P1", Key1 = "MTHPCD63", Key2 = "" });
                response = await client.GetSiteParametersAsync(new Pulse.Grpc.ReferenceData.SiteParameterRequest { Sitcd = "**", Key1 = "MTHPCD61", Key2 = "" });
                response = await client.GetSiteParametersAsync(new Pulse.Grpc.ReferenceData.SiteParameterRequest { Sitcd = "**", Key1 = "REPORTS", Key2 = "" });
                response = await client.GetSiteParametersAsync(new Pulse.Grpc.ReferenceData.SiteParameterRequest { Sitcd = "**", Key1 = "MTHPCD82", Key2 = "MRKTDEPTTEXT" });
                response = await client.GetSiteParametersAsync(new Pulse.Grpc.ReferenceData.SiteParameterRequest { Sitcd = "**", Key1 = "MTHPCD63", Key2 = "SHOW_PANSUB" });

                //#region rptparam

                //response = await _httpClient.GetAsync("odata/rptparam?$filter=rident eq 'SESSION_TEAMREPORT' and sitcd eq '**'", cancellationToken);
                //response.EnsureSuccessStatusCode();

                //response = await _httpClient.GetAsync("odata/rptparam?$filter=rident eq 'SESSION_APPOINTMENTGRID' and sitcd eq '**'", cancellationToken);
                //response.EnsureSuccessStatusCode();

                //response = await _httpClient.GetAsync("odata/rptparam?$filter=rident eq 'SESSION_DONORAPPOINTMENTS' and sitcd eq '**'", cancellationToken);
                //response.EnsureSuccessStatusCode();

                //response = await _httpClient.GetAsync("odata/rptparam?$filter=rident eq 'SESSION_CANCEL_TRAN_FAILS' and sitcd eq '**'", cancellationToken);
                //response.EnsureSuccessStatusCode();

                //response = await _httpClient.GetAsync("odata/rptparam?$filter=rident eq 'SESSION_MANUFACTURING_DIARY' and sitcd eq '**'", cancellationToken);
                //response.EnsureSuccessStatusCode();

                //response = await _httpClient.GetAsync("odata/rptparam?$filter=rident eq 'SESSION_ROTAREPORT' and sitcd eq '**'", cancellationToken);
                //response.EnsureSuccessStatusCode();

                //response = await _httpClient.GetAsync("odata/rptparam?$filter=rident eq 'WALKIN_LIST' and sitcd eq '**'", cancellationToken);
                //response.EnsureSuccessStatusCode();

                st.Stop();
                file.WriteLine(st.Elapsed);
                file.WriteLine(st.ElapsedMilliseconds);
                file.Flush();

                //#endregion
            }
        }
    }
}
