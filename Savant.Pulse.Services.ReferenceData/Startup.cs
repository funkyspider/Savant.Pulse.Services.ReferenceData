using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Savant.Pulse.DataAccessLayer.ReferenceData;


using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Savant.Pulse.DataAccessLayer.ReferenceData.Models;
using Savant.Pulse.WebApi.ReferenceData.Services;


namespace Savant.Pulse.Services.ReferenceData
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddOData();


            services.AddDbContext<PulseReferenceContext>();
            services.AddLogging(config =>
            {
                config.AddConsole();
                config.SetMinimumLevel(LogLevel.Information);
            });
            services.AddControllers();

            services.AddTransient<IReferenceDataService, ReferenceDataService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            var builder = new ODataConventionModelBuilder(app.ApplicationServices);
            ConfigureOdataEntities(builder);

            app.UseMvc(routeBuilder =>
            {
                // and this line to enable OData query option, for example $filter
                routeBuilder.Select().Expand().Filter().OrderBy().MaxTop(100).Count();

                routeBuilder.MapODataServiceRoute("ODataRoute", "odata", builder.GetEdmModel());

                // uncomment the following line to Work-around for #1175 in beta1
                routeBuilder.EnableDependencyInjection();
            });

            //            app.UseHttpsRedirection();
            //            app.UseRouting();
            //            app.UseAuthorization();
            //            app.UseEndpoints(endpoints =>
            //            {
            //                endpoints.MapControllers();
            //            });
        }

        private static void ConfigureOdataEntities(ODataConventionModelBuilder builder)
        {
            builder.EntitySet<Abocon>("Abocon");
            builder.EntitySet<Abotrn>("Abotrn");
            builder.EntitySet<Addrclen>("Addrclen");
            builder.EntitySet<Addtvlnk>("Addtvlnk");
            builder.EntitySet<Addtvref>("Addtvref");
            builder.EntitySet<Adhoctpl>("Adhoctpl");
            builder.EntitySet<Archive>("Archive");
            builder.EntitySet<Arcref>("Arcref");
            builder.EntitySet<Attdesc>("Attdesc");
            builder.EntitySet<Audevent>("Audevent");
            builder.EntitySet<Awardcon>("Awardcon");
            builder.EntitySet<Awardpre>("Awardpre");
            builder.EntitySet<Bankhols>("Bankhols");
            builder.EntitySet<Bctflag>("Bctflag");
            builder.EntitySet<Bldchrpr>("Bldchrpr");
            builder.EntitySet<Booklimt>("Booklimt");
            builder.EntitySet<Cancreas>("Cancreas");
            builder.EntitySet<Cardmand>("Cardmand");
            builder.EntitySet<Ccexdon>("Ccexdon");
            builder.EntitySet<Ccsdist>("Ccsdist");
            builder.EntitySet<Chntimes>("Chntimes");
            builder.EntitySet<Comchanl>("Comchanl");
            builder.EntitySet<Comdet>("Comdet");
            builder.EntitySet<Comdfpln>("Comdfpln");
            builder.EntitySet<Comscat>("Comscat");
            builder.EntitySet<Comsetrf>("Comsetrf");
            builder.EntitySet<Comsopt>("Comsopt");
            builder.EntitySet<Comsysct>("Comsysct");
            builder.EntitySet<Comsystm>("Comsystm");
            builder.EntitySet<Comtrigr>("Comtrigr");
            builder.EntitySet<Countysp>("Countysp");
            builder.EntitySet<Datacul2>("Datacul2");
            builder.EntitySet<Datacull>("Datacull");
            builder.EntitySet<Dbuser>("Dbuser");
            builder.EntitySet<Defgrid>("Defgrid");
            builder.EntitySet<Deftst>("Deftst");
            builder.EntitySet<Dntrntbs>("Dntrntbs");
            builder.EntitySet<Donelig>("Donelig");
            builder.EntitySet<Donemprm>("Donemprm");
            builder.EntitySet<Donmaint>("Donmaint");
            builder.EntitySet<Donrfddl>("Donrfddl");
            builder.EntitySet<Donrfedt>("Donrfedt");
            builder.EntitySet<Donrfeml>("Donrfeml");
            builder.EntitySet<Donrffrm>("Donrffrm");
            builder.EntitySet<Donrflnk>("Donrflnk");
            builder.EntitySet<Donrfprp>("Donrfprp");
            builder.EntitySet<Donrfrad>("Donrfrad");
            builder.EntitySet<Donrfrsp>("Donrfrsp");
            builder.EntitySet<Donrfsec>("Donrfsec");
            builder.EntitySet<Donrfsum>("Donrfsum");
            builder.EntitySet<Donrftyp>("Donrftyp");
            builder.EntitySet<Dseldate>("Dseldate");
            builder.EntitySet<Dselsrce>("Dselsrce");
            builder.EntitySet<Dseltab>("Dseltab");
            builder.EntitySet<Dseltmpl>("Dseltmpl");
            builder.EntitySet<Dseltmrl>("Dseltmrl");
            builder.EntitySet<Dttype>("Dttype");
            builder.EntitySet<Emaildet>("Emaildet");
            builder.EntitySet<Emailkey>("Emailkey");
            builder.EntitySet<Emaladdr>("Emaladdr");
            builder.EntitySet<Errcode>("Errcode");
            builder.EntitySet<Ethcats>("Ethcats");
            builder.EntitySet<Ethorig>("Ethorig");
            builder.EntitySet<Exccall>("Exccall");
            builder.EntitySet<Fctcon>("Fctcon");
            builder.EntitySet<Gcselect>("Gcselect");
            builder.EntitySet<Hapostcd>("Hapostcd");
            builder.EntitySet<Helphnts>("Helphnts");
            builder.EntitySet<Holddept>("Holddept");
            builder.EntitySet<Isoctry>("Isoctry");
            builder.EntitySet<Jobdays>("Jobdays");
            builder.EntitySet<Jobname>("Jobname");
            builder.EntitySet<Labelfit>("Labelfit");
            builder.EntitySet<Lbmrgrle>("Lbmrgrle");
            builder.EntitySet<Letcancd>("Letcancd");
            builder.EntitySet<Maildet>("Maildet");
            builder.EntitySet<Mailins>("Mailins");
            builder.EntitySet<Mailslct>("Mailslct");
            builder.EntitySet<Manident>("Manident");
            builder.EntitySet<Mergecat>("Mergecat");
            builder.EntitySet<Mergerun>("Mergerun");
            builder.EntitySet<Mergrule>("Mergrule");
            builder.EntitySet<Messdets>("Messdets");
            builder.EntitySet<Messhelp>("Messhelp");
            builder.EntitySet<Messtext>("Messtext");
            builder.EntitySet<Mmfortyp>("Mmfortyp");
            builder.EntitySet<Mobilcms>("Mobilcms");
            builder.EntitySet<Mrgcntrl>("Mrgcntrl");
            builder.EntitySet<Mrgerrcd>("Mrgerrcd");
            builder.EntitySet<Mrgfield>("Mrgfield");
            builder.EntitySet<Mrgprfxs>("Mrgprfxs");
            builder.EntitySet<Mrktdept>("Mrktdept");
            builder.EntitySet<Mrktuser>("Mrktuser");
            builder.EntitySet<Mthcon>("Mthcon");
            builder.EntitySet<Mthsid>("Mthsid");
            builder.EntitySet<Mthsite>("Mthsite");
            builder.EntitySet<Namevar>("Namevar");
            builder.EntitySet<Ncccolor>("Ncccolor");
            builder.EntitySet<Nggrconv>("Nggrconv");
            builder.EntitySet<Nhsiaref>("Nhsiaref");
            builder.EntitySet<Nmresdsp>("Nmresdsp");
            builder.EntitySet<Nonsescm>("Nonsescm");
            builder.EntitySet<Ooasuppl>("Ooasuppl");
            builder.EntitySet<Panref>("Panref");
            builder.EntitySet<Pcklot>("Pcklot");
            builder.EntitySet<Pcktyp>("Pcktyp");
            builder.EntitySet<Pcl70ref>("Pcl70ref");
            builder.EntitySet<Phonekey>("Phonekey");
            builder.EntitySet<Placegrid>("Placegrid");
            builder.EntitySet<Pltran>("Pltran");
            builder.EntitySet<Pntychk>("Pntychk");
            builder.EntitySet<Postrate>("Postrate");
            builder.EntitySet<Prncmnd>("Prncmnd");
            builder.EntitySet<Procint>("Procint");
            builder.EntitySet<Proclink>("Proclink");
            builder.EntitySet<Procsub>("Procsub");
            builder.EntitySet<Prodcell>("Prodcell");
            builder.EntitySet<Prodct>("Prodct");
            builder.EntitySet<Provdets>("Provdets");
            builder.EntitySet<Pstcdupd>("Pstcdupd");
            builder.EntitySet<Ptypbch>("Ptypbch");
            builder.EntitySet<Pulsedb>("Pulsedb");
            builder.EntitySet<Pulsrprt>("Pulsrprt");
            builder.EntitySet<Q46cntrl>("Q46cntrl");
            builder.EntitySet<Qcodes>("Qcodes");
            builder.EntitySet<Qjobs>("Qjobs");
            builder.EntitySet<Quename>("Quename");
            builder.EntitySet<Queueref>("Queueref");
            builder.EntitySet<Recrcat>("Recrcat");
            builder.EntitySet<Refaudit>("Refaudit");
            builder.EntitySet<Refdescn>("Refdescn");
            builder.EntitySet<Refdonor>("Refdonor");
            builder.EntitySet<Refmess>("Refmess");
            builder.EntitySet<Reftable>("Reftable");
            builder.EntitySet<Relcheck>("Relcheck");
            builder.EntitySet<Reprtout>("Reprtout");
            builder.EntitySet<Retrpool>("Retrpool");
            builder.EntitySet<Rptparam>("Rptparam");
            builder.EntitySet<Rpttxt>("Rpttxt");
            builder.EntitySet<S17odate>("S17odate");
            builder.EntitySet<S46ref>("S46ref");
            builder.EntitySet<Samptyp>("Samptyp");
            builder.EntitySet<Sccmslct>("Sccmslct");
            builder.EntitySet<Scgenatt>("Scgenatt");
            builder.EntitySet<Scialocn>("Scialocn");
            builder.EntitySet<Scinsatt>("Scinsatt");
            builder.EntitySet<Scmessdsc>("Scmessdsc");
            builder.EntitySet<Scmessge>("Scmessge");
            builder.EntitySet<Scomtmpl>("Scomtmpl");
            builder.EntitySet<Scpertab>("Scpertab");
            builder.EntitySet<Scselsrc>("Scselsrc");
            builder.EntitySet<Scslrlcn>("Scslrlcn");
            builder.EntitySet<Scslrlia>("Scslrlia");
            builder.EntitySet<Sctmslrl>("Sctmslrl");
            builder.EntitySet<Servpo>("Servpo");
            builder.EntitySet<Sesfndpt>("Sesfndpt");
            builder.EntitySet<Sesoutcm>("Sesoutcm");
            builder.EntitySet<Sesprdcd>("Sesprdcd");
            builder.EntitySet<Sesscmdt>("Sesscmdt");
            builder.EntitySet<Sessprio>("Sessprio");
            builder.EntitySet<Sessprm>("Sessprm");
            builder.EntitySet<Sessproc>("Sessproc");
            builder.EntitySet<Sessrev>("Sessrev");
            builder.EntitySet<Simlist>("Simlist");
            builder.EntitySet<Sitedmnd>("Sitedmnd");
            builder.EntitySet<Siteprm>("Siteprm");
            builder.EntitySet<Sityrseq>("Sityrseq");
            builder.EntitySet<Smsdet>("Smsdet");
            builder.EntitySet<Teldet>("Teldet");
            builder.EntitySet<Telnoref>("Telnoref");
            builder.EntitySet<U06ref>("U06ref");
            builder.EntitySet<Usremail>("Usremail");
            builder.EntitySet<Valemail>("Valemail");
            builder.EntitySet<Vennowrk>("Vennowrk");
            builder.EntitySet<Vnctyprq>("Vnctyprq");
            builder.EntitySet<Waitprm>("Waitprm");
            builder.EntitySet<Wrdmmdef>("Wrdmmdef");

        }
    }
}
