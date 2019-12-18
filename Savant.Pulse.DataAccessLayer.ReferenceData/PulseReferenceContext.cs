using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Savant.Pulse.DataAccessLayer.ReferenceData.Models;


namespace Savant.Pulse.DataAccessLayer.ReferenceData
{
    public partial class PulseReferenceContext : DbContext
    {
        public PulseReferenceContext()
        {
        }

        public PulseReferenceContext(DbContextOptions<PulseReferenceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abocon> Abocon { get; set; }
        public virtual DbSet<Abotrn> Abotrn { get; set; }
        public virtual DbSet<Addrclen> Addrclen { get; set; }
        public virtual DbSet<Addtvlnk> Addtvlnk { get; set; }
        public virtual DbSet<Addtvref> Addtvref { get; set; }
        public virtual DbSet<Adhoctpl> Adhoctpl { get; set; }
        public virtual DbSet<Archive> Archive { get; set; }
        public virtual DbSet<Arcmodes> Arcmodes { get; set; }
        public virtual DbSet<Arcref> Arcref { get; set; }
        public virtual DbSet<Arcvmode> Arcvmode { get; set; }
        public virtual DbSet<Attdesc> Attdesc { get; set; }
        public virtual DbSet<Audevent> Audevent { get; set; }
        public virtual DbSet<Awardcon> Awardcon { get; set; }
        public virtual DbSet<Awardpre> Awardpre { get; set; }
        public virtual DbSet<Bankhols> Bankhols { get; set; }
        public virtual DbSet<Bchrprio> Bchrprio { get; set; }
        public virtual DbSet<Bctflag> Bctflag { get; set; }
        public virtual DbSet<Bldchrpr> Bldchrpr { get; set; }
        public virtual DbSet<Booklimt> Booklimt { get; set; }
        public virtual DbSet<Cancreas> Cancreas { get; set; }
        public virtual DbSet<Cardmand> Cardmand { get; set; }
        public virtual DbSet<Ccexdon> Ccexdon { get; set; }
        public virtual DbSet<Ccsdist> Ccsdist { get; set; }
        public virtual DbSet<Chntimes> Chntimes { get; set; }
        public virtual DbSet<Comchanl> Comchanl { get; set; }
        public virtual DbSet<Comdet> Comdet { get; set; }
        public virtual DbSet<Comdfpln> Comdfpln { get; set; }
        public virtual DbSet<Comscat> Comscat { get; set; }
        public virtual DbSet<Comsetrf> Comsetrf { get; set; }
        public virtual DbSet<Comsopt> Comsopt { get; set; }
        public virtual DbSet<Comsysct> Comsysct { get; set; }
        public virtual DbSet<Comsystm> Comsystm { get; set; }
        public virtual DbSet<Comtrigr> Comtrigr { get; set; }
        public virtual DbSet<Countysp> Countysp { get; set; }
        public virtual DbSet<Datacul2> Datacul2 { get; set; }
        public virtual DbSet<Datacull> Datacull { get; set; }
        public virtual DbSet<Dbuser> Dbuser { get; set; }
        public virtual DbSet<Defgrid> Defgrid { get; set; }
        public virtual DbSet<Deftst> Deftst { get; set; }
        public virtual DbSet<Dntrntbs> Dntrntbs { get; set; }
        public virtual DbSet<Donelig> Donelig { get; set; }
        public virtual DbSet<Donemprm> Donemprm { get; set; }
        public virtual DbSet<Donmaint> Donmaint { get; set; }
        public virtual DbSet<Donrfddl> Donrfddl { get; set; }
        public virtual DbSet<Donrfedt> Donrfedt { get; set; }
        public virtual DbSet<Donrfeml> Donrfeml { get; set; }
        public virtual DbSet<Donrffrm> Donrffrm { get; set; }
        public virtual DbSet<Donrflnk> Donrflnk { get; set; }
        public virtual DbSet<Donrfprp> Donrfprp { get; set; }
        public virtual DbSet<Donrfrad> Donrfrad { get; set; }
        public virtual DbSet<Donrfrsp> Donrfrsp { get; set; }
        public virtual DbSet<Donrfsec> Donrfsec { get; set; }
        public virtual DbSet<Donrfsum> Donrfsum { get; set; }
        public virtual DbSet<Donrftyp> Donrftyp { get; set; }
        public virtual DbSet<Dseldate> Dseldate { get; set; }
        public virtual DbSet<Dselsrce> Dselsrce { get; set; }
        public virtual DbSet<Dseltab> Dseltab { get; set; }
        public virtual DbSet<Dseltmpl> Dseltmpl { get; set; }
        public virtual DbSet<Dseltmrl> Dseltmrl { get; set; }
        public virtual DbSet<Dttype> Dttype { get; set; }
        public virtual DbSet<Emaildet> Emaildet { get; set; }
        public virtual DbSet<Emailkey> Emailkey { get; set; }
        public virtual DbSet<Emaladdr> Emaladdr { get; set; }
        public virtual DbSet<Errcode> Errcode { get; set; }
        public virtual DbSet<Ethcats> Ethcats { get; set; }
        public virtual DbSet<Ethorig> Ethorig { get; set; }
        public virtual DbSet<Exccall> Exccall { get; set; }
        public virtual DbSet<Fctcon> Fctcon { get; set; }
        public virtual DbSet<Gcselect> Gcselect { get; set; }
        public virtual DbSet<Hapostcd> Hapostcd { get; set; }
        public virtual DbSet<Helphnts> Helphnts { get; set; }
        public virtual DbSet<Holddept> Holddept { get; set; }
        public virtual DbSet<Isoctry> Isoctry { get; set; }
        public virtual DbSet<Jobdays> Jobdays { get; set; }
        public virtual DbSet<Jobname> Jobname { get; set; }
        public virtual DbSet<L62ref> L62ref { get; set; }
        public virtual DbSet<L63ref> L63ref { get; set; }
        public virtual DbSet<Labelfit> Labelfit { get; set; }
        public virtual DbSet<Lbmrgrle> Lbmrgrle { get; set; }
        public virtual DbSet<Letcancd> Letcancd { get; set; }
        public virtual DbSet<Maildet> Maildet { get; set; }
        public virtual DbSet<Mailins> Mailins { get; set; }
        public virtual DbSet<Mailslct> Mailslct { get; set; }
        public virtual DbSet<Manident> Manident { get; set; }
        public virtual DbSet<Mergecat> Mergecat { get; set; }
        public virtual DbSet<Mergerun> Mergerun { get; set; }
        public virtual DbSet<Mergrule> Mergrule { get; set; }
        public virtual DbSet<Messdets> Messdets { get; set; }
        public virtual DbSet<Messhelp> Messhelp { get; set; }
        public virtual DbSet<Messtext> Messtext { get; set; }
        public virtual DbSet<Mmfortyp> Mmfortyp { get; set; }
        public virtual DbSet<Mobilcms> Mobilcms { get; set; }
        public virtual DbSet<Mrgcntrl> Mrgcntrl { get; set; }
        public virtual DbSet<Mrgerrcd> Mrgerrcd { get; set; }
        public virtual DbSet<Mrgfield> Mrgfield { get; set; }
        public virtual DbSet<Mrgprfxs> Mrgprfxs { get; set; }
        public virtual DbSet<Mrktdept> Mrktdept { get; set; }
        public virtual DbSet<Mrktuser> Mrktuser { get; set; }
        public virtual DbSet<Mthcon> Mthcon { get; set; }
        public virtual DbSet<Mthsid> Mthsid { get; set; }
        public virtual DbSet<Mthsite> Mthsite { get; set; }
        public virtual DbSet<Namevar> Namevar { get; set; }
        public virtual DbSet<Ncccolor> Ncccolor { get; set; }
        public virtual DbSet<Nggrconv> Nggrconv { get; set; }
        public virtual DbSet<Nhsiaref> Nhsiaref { get; set; }
        public virtual DbSet<Nmresdsp> Nmresdsp { get; set; }
        public virtual DbSet<Nonsescm> Nonsescm { get; set; }
        public virtual DbSet<Ooasuppl> Ooasuppl { get; set; }
        public virtual DbSet<Osdate> Osdate { get; set; }
        public virtual DbSet<Panref> Panref { get; set; }
        public virtual DbSet<Pcklot> Pcklot { get; set; }
        public virtual DbSet<Pcktyp> Pcktyp { get; set; }
        public virtual DbSet<Pcl70ref> Pcl70ref { get; set; }
        public virtual DbSet<Phonekey> Phonekey { get; set; }
        public virtual DbSet<Placegrid> Placegrid { get; set; }
        public virtual DbSet<Pltran> Pltran { get; set; }
        public virtual DbSet<Pntychk> Pntychk { get; set; }
        public virtual DbSet<Postrate> Postrate { get; set; }
        public virtual DbSet<Prncmnd> Prncmnd { get; set; }
        public virtual DbSet<Procint> Procint { get; set; }
        public virtual DbSet<Proclink> Proclink { get; set; }
        public virtual DbSet<Procsub> Procsub { get; set; }
        public virtual DbSet<Prodcell> Prodcell { get; set; }
        public virtual DbSet<Prodct> Prodct { get; set; }
        public virtual DbSet<Provdets> Provdets { get; set; }
        public virtual DbSet<Pstcdupd> Pstcdupd { get; set; }
        public virtual DbSet<Ptypbch> Ptypbch { get; set; }
        public virtual DbSet<Pulsedb> Pulsedb { get; set; }
        public virtual DbSet<Pulsrprt> Pulsrprt { get; set; }
        public virtual DbSet<Q46cntrl> Q46cntrl { get; set; }
        public virtual DbSet<Qcodes> Qcodes { get; set; }
        public virtual DbSet<Qjobs> Qjobs { get; set; }
        public virtual DbSet<Quename> Quename { get; set; }
        public virtual DbSet<Queueref> Queueref { get; set; }
        public virtual DbSet<Recrcat> Recrcat { get; set; }
        public virtual DbSet<Refaudit> Refaudit { get; set; }
        public virtual DbSet<Refdescn> Refdescn { get; set; }
        public virtual DbSet<Refdonor> Refdonor { get; set; }
        public virtual DbSet<Refmess> Refmess { get; set; }
        public virtual DbSet<Reftable> Reftable { get; set; }
        public virtual DbSet<Relcheck> Relcheck { get; set; }
        public virtual DbSet<Reprtout> Reprtout { get; set; }
        public virtual DbSet<Retrpool> Retrpool { get; set; }
        public virtual DbSet<Rptparam> Rptparam { get; set; }
        public virtual DbSet<Rpttxt> Rpttxt { get; set; }
        public virtual DbSet<S17odate> S17odate { get; set; }
        public virtual DbSet<S46ref> S46ref { get; set; }
        public virtual DbSet<Samptyp> Samptyp { get; set; }
        public virtual DbSet<Sccmslct> Sccmslct { get; set; }
        public virtual DbSet<Scgenatt> Scgenatt { get; set; }
        public virtual DbSet<Scialocn> Scialocn { get; set; }
        public virtual DbSet<Scinsatt> Scinsatt { get; set; }
        public virtual DbSet<Scmessdsc> Scmessdsc { get; set; }
        public virtual DbSet<Scmessge> Scmessge { get; set; }
        public virtual DbSet<Scomtmpl> Scomtmpl { get; set; }
        public virtual DbSet<Scpertab> Scpertab { get; set; }
        public virtual DbSet<Scselsrc> Scselsrc { get; set; }
        public virtual DbSet<Scslrlcn> Scslrlcn { get; set; }
        public virtual DbSet<Scslrlia> Scslrlia { get; set; }
        public virtual DbSet<Sctmslrl> Sctmslrl { get; set; }
        public virtual DbSet<Servpo> Servpo { get; set; }
        public virtual DbSet<Sesfndpt> Sesfndpt { get; set; }
        public virtual DbSet<Sesoutcm> Sesoutcm { get; set; }
        public virtual DbSet<Sesprdcd> Sesprdcd { get; set; }
        public virtual DbSet<Sesscmdt> Sesscmdt { get; set; }
        public virtual DbSet<Sessprio> Sessprio { get; set; }
        public virtual DbSet<Sessprm> Sessprm { get; set; }
        public virtual DbSet<Sessproc> Sessproc { get; set; }
        public virtual DbSet<Sessrev> Sessrev { get; set; }
        public virtual DbSet<Simlist> Simlist { get; set; }
        public virtual DbSet<Sitedmnd> Sitedmnd { get; set; }
        public virtual DbSet<Siteprm> Siteprm { get; set; }
        public virtual DbSet<Sityrseq> Sityrseq { get; set; }
        public virtual DbSet<Smsdet> Smsdet { get; set; }
        public virtual DbSet<Teldet> Teldet { get; set; }
        public virtual DbSet<Telnoref> Telnoref { get; set; }
        public virtual DbSet<U06ref> U06ref { get; set; }
        public virtual DbSet<Usremail> Usremail { get; set; }
        public virtual DbSet<Valemail> Valemail { get; set; }
        public virtual DbSet<Vennowrk> Vennowrk { get; set; }
        public virtual DbSet<Vnctyprq> Vnctyprq { get; set; }
        public virtual DbSet<Waitprm> Waitprm { get; set; }
        public virtual DbSet<Weightbg> Weightbg { get; set; }
        public virtual DbSet<Weightph> Weightph { get; set; }
        public virtual DbSet<Weighttm> Weighttm { get; set; }
        public virtual DbSet<Wrdmmdef> Wrdmmdef { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Pulse_Reference;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abocon>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("ABOCON");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abogr)
                    .HasColumnName("ABOGR")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Abotrn>(entity =>
            {
                entity.HasKey(e => e.Barcd);

                entity.ToTable("ABOTRN");

                entity.Property(e => e.Barcd)
                    .HasColumnName("BARCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Abogr)
                    .HasColumnName("ABOGR")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Labelty)
                    .HasColumnName("LABELTY")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rhgr)
                    .HasColumnName("RHGR")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Addrclen>(entity =>
            {
                entity.HasKey(e => new { e.Ptable, e.Pcolumn });

                entity.ToTable("ADDRCLEN");

                entity.Property(e => e.Ptable)
                    .HasColumnName("PTABLE")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Pcolumn)
                    .HasColumnName("PCOLUMN")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Addr1col)
                    .HasColumnName("ADDR1COL")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Addr2col)
                    .HasColumnName("ADDR2COL")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Addr3col)
                    .HasColumnName("ADDR3COL")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Addr4col)
                    .HasColumnName("ADDR4COL")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Addr5col)
                    .HasColumnName("ADDR5COL")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Addr6col)
                    .HasColumnName("ADDR6COL")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Addrtype)
                    .HasColumnName("ADDRTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inusecol)
                    .HasColumnName("INUSECOL")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Keycol)
                    .HasColumnName("KEYCOL")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Keycol2)
                    .HasColumnName("KEYCOL2")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Keycol3)
                    .HasColumnName("KEYCOL3")
                    .HasMaxLength(12)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Addtvlnk>(entity =>
            {
                entity.HasKey(e => new { e.Addrefcd, e.Pckcod });

                entity.ToTable("ADDTVLNK");

                entity.Property(e => e.Addrefcd)
                    .HasColumnName("ADDREFCD")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Pckcod)
                    .HasColumnName("PCKCOD")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Addtvref>(entity =>
            {
                entity.HasKey(e => e.Addrefcd);

                entity.ToTable("ADDTVREF");

                entity.Property(e => e.Addrefcd)
                    .HasColumnName("ADDREFCD")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Addrefds)
                    .HasColumnName("ADDREFDS")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Adhoctpl>(entity =>
            {
                entity.HasKey(e => new { e.Commscd, e.Comchncd, e.Sitcd, e.Langcode });

                entity.ToTable("ADHOCTPL");

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Comchncd)
                    .HasColumnName("COMCHNCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Langcode)
                    .HasColumnName("LANGCODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Tmplfile)
                    .HasColumnName("TMPLFILE")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Archive>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("ARCHIVE");

                entity.Property(e => e.Keyword)
                    .HasColumnName("KEYWORD")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Param)
                    .HasColumnName("PARAM")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Arcmodes>(entity =>
            {
                entity.HasKey(e => new { e.Dayno, e.Strttime });

                entity.ToTable("ARCMODES");

                entity.Property(e => e.Dayno).HasColumnName("DAYNO");

                entity.Property(e => e.Strttime)
                    .HasColumnName("STRTTIME")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Archmode)
                    .HasColumnName("ARCHMODE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Archreas)
                    .HasColumnName("ARCHREAS")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Arcmnote)
                    .HasColumnName("ARCMNOTE")
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Stoptime)
                    .HasColumnName("STOPTIME")
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Arcref>(entity =>
            {
                entity.HasKey(e => new { e.Arcsys, e.Tabname });

                entity.ToTable("ARCREF");

                entity.Property(e => e.Arcsys)
                    .HasColumnName("ARCSYS")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tabname)
                    .HasColumnName("TABNAME")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Autocop)
                    .HasColumnName("AUTOCOP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Autodel)
                    .HasColumnName("AUTODEL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Key1)
                    .HasColumnName("KEY1")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Key2)
                    .HasColumnName("KEY2")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Tabtype)
                    .HasColumnName("TABTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Arcvmode>(entity =>
            {
                entity.HasKey(e => e.Archmode);

                entity.ToTable("ARCVMODE");

                entity.Property(e => e.Archmode)
                    .HasColumnName("ARCHMODE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Arcmnote)
                    .HasColumnName("ARCMNOTE")
                    .HasMaxLength(500)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Attdesc>(entity =>
            {
                entity.HasKey(e => new { e.Restype, e.Mnemonic });

                entity.ToTable("ATTDESC");

                entity.Property(e => e.Restype)
                    .HasColumnName("RESTYPE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Mnemonic)
                    .HasColumnName("MNEMONIC")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Attdescl)
                    .HasColumnName("ATTDESCL")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Attdescs)
                    .HasColumnName("ATTDESCS")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Audevent>(entity =>
            {
                entity.HasKey(e => e.Auditcd);

                entity.ToTable("AUDEVENT");

                entity.Property(e => e.Auditcd)
                    .HasColumnName("AUDITCD")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Auditds)
                    .HasColumnName("AUDITDS")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Auditdsl)
                    .HasColumnName("AUDITDSL")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Auditdsw)
                    .HasColumnName("AUDITDSW")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Awardcon>(entity =>
            {
                entity.HasKey(e => e.Awrdcond);

                entity.ToTable("AWARDCON");

                entity.Property(e => e.Awrdcond)
                    .HasColumnName("AWRDCOND")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Awrdinst)
                    .HasColumnName("AWRDINST")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Condescl)
                    .HasColumnName("CONDESCL")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Condescs)
                    .HasColumnName("CONDESCS")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Usercond)
                    .HasColumnName("USERCOND")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Awardpre>(entity =>
            {
                entity.HasKey(e => new { e.Nocreds, e.Awrdin });

                entity.ToTable("AWARDPRE");

                entity.Property(e => e.Nocreds).HasColumnName("NOCREDS");

                entity.Property(e => e.Awrdin)
                    .HasColumnName("AWRDIN")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Credassm)
                    .HasColumnName("CREDASSM")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Credcom)
                    .HasColumnName("CREDCOM")
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Bankhols>(entity =>
            {
                entity.HasKey(e => e.Holdate);

                entity.ToTable("BANKHOLS");

                entity.Property(e => e.Holdate)
                    .HasColumnName("HOLDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Holdesc)
                    .HasColumnName("HOLDESC")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Refinuse)
                    .HasColumnName("REFINUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Bchrprio>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Bchcd });

                entity.ToTable("BCHRPRIO");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Bchcd)
                    .HasColumnName("BCHCD")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Bldprio).HasColumnName("BLDPRIO");
            });

            modelBuilder.Entity<Bctflag>(entity =>
            {
                entity.HasKey(e => new { e.Prdcd, e.Keyword });

                entity.ToTable("BCTFLAG");

                entity.Property(e => e.Prdcd)
                    .HasColumnName("PRDCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Keyword)
                    .HasColumnName("KEYWORD")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Flagchar)
                    .HasColumnName("FLAGCHAR")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Bldchrpr>(entity =>
            {
                entity.HasKey(e => new { e.Bchcd, e.Reslt });

                entity.ToTable("BLDCHRPR");

                entity.Property(e => e.Bchcd)
                    .HasColumnName("BCHCD")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Reslt)
                    .HasColumnName("RESLT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Prior).HasColumnName("PRIOR");
            });

            modelBuilder.Entity<Booklimt>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.Code, e.Strtdate, e.Enddate });

                entity.ToTable("BOOKLIMT");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Strtdate)
                    .HasColumnName("STRTDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Enddate)
                    .HasColumnName("ENDDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Limit).HasColumnName("LIMIT");
            });

            modelBuilder.Entity<Cancreas>(entity =>
            {
                entity.HasKey(e => e.Canccd);

                entity.ToTable("CANCREAS");

                entity.Property(e => e.Canccd)
                    .HasColumnName("CANCCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Cancdesc)
                    .HasColumnName("CANCDESC")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cardmand>(entity =>
            {
                entity.HasKey(e => e.Bchcd);

                entity.ToTable("CARDMAND");

                entity.Property(e => e.Bchcd)
                    .HasColumnName("BCHCD")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Reslt)
                    .HasColumnName("RESLT")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ccexdon>(entity =>
            {
                entity.HasKey(e => new { e.Item, e.Value });

                entity.ToTable("CCEXDON");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ccsdist>(entity =>
            {
                entity.HasKey(e => e.Initial);

                entity.ToTable("CCSDIST");

                entity.Property(e => e.Initial)
                    .HasColumnName("INITIAL")
                    .ValueGeneratedNever();

                entity.Property(e => e.Increm).HasColumnName("INCREM");
            });

            modelBuilder.Entity<Chntimes>(entity =>
            {
                entity.HasKey(e => e.Comchncd);

                entity.ToTable("CHNTIMES");

                entity.Property(e => e.Comchncd)
                    .HasColumnName("COMCHNCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Nxtdatim)
                    .IsRequired()
                    .HasColumnName("NXTDATIM")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Comchanl>(entity =>
            {
                entity.HasKey(e => e.Comchncd);

                entity.ToTable("COMCHANL");

                entity.Property(e => e.Comchncd)
                    .HasColumnName("COMCHNCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Comcatcd)
                    .HasColumnName("COMCATCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Comchnds)
                    .HasColumnName("COMCHNDS")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Jobid)
                    .HasColumnName("JOBID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Rnperiod)
                    .HasColumnName("RNPERIOD")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Runstart)
                    .HasColumnName("RUNSTART")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Runstop)
                    .HasColumnName("RUNSTOP")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Typetext)
                    .HasColumnName("TYPETEXT")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Comdet>(entity =>
            {
                entity.HasKey(e => e.Commscd);

                entity.ToTable("COMDET");

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Bulkcomm)
                    .HasColumnName("BULKCOMM")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Commsds)
                    .HasColumnName("COMMSDS")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Commsdsw)
                    .HasColumnName("COMMSDSW")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Comsyscd)
                    .HasColumnName("COMSYSCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Culldays).HasColumnName("CULLDAYS");

                entity.Property(e => e.Dhcreq)
                    .HasColumnName("DHCREQ")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Lettmand)
                    .HasColumnName("LETTMAND")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Ovrdopt)
                    .HasColumnName("OVRDOPT")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Comdfpln>(entity =>
            {
                entity.HasKey(e => new { e.Strtdate, e.Pntycd });

                entity.ToTable("COMDFPLN");

                entity.Property(e => e.Strtdate)
                    .HasColumnName("STRTDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Pntycd)
                    .HasColumnName("PNTYCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Ccomdays).HasColumnName("CCOMDAYS");

                entity.Property(e => e.Closdays).HasColumnName("CLOSDAYS");

                entity.Property(e => e.Enddate)
                    .HasColumnName("ENDDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Primtmpl)
                    .HasColumnName("PRIMTMPL")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Rmdtmpl)
                    .HasColumnName("RMDTMPL")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Selndays).HasColumnName("SELNDAYS");

                entity.Property(e => e.Wcomdays).HasColumnName("WCOMDAYS");
            });

            modelBuilder.Entity<Comscat>(entity =>
            {
                entity.HasKey(e => e.Comcatcd);

                entity.ToTable("COMSCAT");

                entity.Property(e => e.Comcatcd)
                    .HasColumnName("COMCATCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Comcatds)
                    .HasColumnName("COMCATDS")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Relprio).HasColumnName("RELPRIO");
            });

            modelBuilder.Entity<Comsetrf>(entity =>
            {
                entity.HasKey(e => e.Comvalue);

                entity.ToTable("COMSETRF");

                entity.Property(e => e.Comvalue)
                    .HasColumnName("COMVALUE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Comcatcd)
                    .HasColumnName("COMCATCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Desc)
                    .HasColumnName("DESC")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Comsopt>(entity =>
            {
                entity.HasKey(e => new { e.Commscd, e.Comchncd });

                entity.ToTable("COMSOPT");

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Comchncd)
                    .HasColumnName("COMCHNCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Comdelay)
                    .HasColumnName("COMDELAY")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Letprio).HasColumnName("LETPRIO");

                entity.Property(e => e.Prvider)
                    .HasColumnName("PRVIDER")
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Comsysct>(entity =>
            {
                entity.HasKey(e => new { e.Comsyscd, e.Comcatcd });

                entity.ToTable("COMSYSCT");

                entity.Property(e => e.Comsyscd)
                    .HasColumnName("COMSYSCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Comcatcd)
                    .HasColumnName("COMCATCD")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Comsystm>(entity =>
            {
                entity.HasKey(e => e.Comsyscd);

                entity.ToTable("COMSYSTM");

                entity.Property(e => e.Comsyscd)
                    .HasColumnName("COMSYSCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Comsysds)
                    .HasColumnName("COMSYSDS")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Comtrigr>(entity =>
            {
                entity.HasKey(e => new { e.Cmtrgpnt, e.Cntcd });

                entity.ToTable("COMTRIGR");

                entity.Property(e => e.Cmtrgpnt)
                    .HasColumnName("CMTRGPNT")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Cntcd)
                    .HasColumnName("CNTCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Param)
                    .HasColumnName("PARAM")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Windesc)
                    .HasColumnName("WINDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Countysp>(entity =>
            {
                entity.HasKey(e => e.County);

                entity.ToTable("COUNTYSP");

                entity.Property(e => e.County)
                    .HasColumnName("COUNTY")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Datacul2>(entity =>
            {
                entity.HasKey(e => new { e.Ptabname, e.Ctabname });

                entity.ToTable("DATACUL2");

                entity.Property(e => e.Ptabname)
                    .HasColumnName("PTABNAME")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Ctabname)
                    .HasColumnName("CTABNAME")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Ccolname)
                    .HasColumnName("CCOLNAME")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Pcolname)
                    .HasColumnName("PCOLNAME")
                    .HasMaxLength(12)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Datacull>(entity =>
            {
                entity.HasKey(e => new { e.Tabname, e.Keycolmn });

                entity.ToTable("DATACULL");

                entity.Property(e => e.Tabname)
                    .HasColumnName("TABNAME")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Keycolmn)
                    .HasColumnName("KEYCOLMN")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Clperiod).HasColumnName("CLPERIOD");

                entity.Property(e => e.Datetype)
                    .HasColumnName("DATETYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Lastcnt).HasColumnName("LASTCNT");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("LASTDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Lastrun)
                    .HasColumnName("LASTRUN")
                    .HasMaxLength(14)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dbuser>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Dbnamecd });

                entity.ToTable("DBUSER");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Dbnamecd)
                    .HasColumnName("DBNAMECD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Userman)
                    .HasColumnName("USERMAN")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Defgrid>(entity =>
            {
                entity.HasKey(e => new { e.Keyval, e.Sesdate, e.Gridtype, e.Pertype, e.Daysect, e.Numbeds, e.Gridsect, e.Timeoff, e.Slotno });

                entity.ToTable("DEFGRID");

                entity.Property(e => e.Keyval)
                    .HasColumnName("KEYVAL")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Sesdate)
                    .HasColumnName("SESDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Gridtype)
                    .HasColumnName("GRIDTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Pertype)
                    .HasColumnName("PERTYPE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Daysect)
                    .HasColumnName("DAYSECT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Numbeds).HasColumnName("NUMBEDS");

                entity.Property(e => e.Gridsect)
                    .HasColumnName("GRIDSECT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Timeoff).HasColumnName("TIMEOFF");

                entity.Property(e => e.Slotno).HasColumnName("SLOTNO");

                entity.Property(e => e.Apporrep)
                    .HasColumnName("APPORREP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Dateupd)
                    .HasColumnName("DATEUPD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Minslots).HasColumnName("MINSLOTS");

                entity.Property(e => e.Proccode)
                    .HasColumnName("PROCCODE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Slottype)
                    .HasColumnName("SLOTTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sltlngth).HasColumnName("SLTLNGTH");

                entity.Property(e => e.Timeupd)
                    .HasColumnName("TIMEUPD")
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Deftst>(entity =>
            {
                entity.HasKey(e => new { e.Bchcd, e.Conflg, e.Treslt, e.Dreslt, e.Cntcd });

                entity.ToTable("DEFTST");

                entity.Property(e => e.Bchcd)
                    .HasColumnName("BCHCD")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Conflg)
                    .HasColumnName("CONFLG")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Treslt)
                    .HasColumnName("TRESLT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Dreslt)
                    .HasColumnName("DRESLT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Cntcd)
                    .HasColumnName("CNTCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Bchtst)
                    .HasColumnName("BCHTST")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Mchman)
                    .HasColumnName("MCHMAN")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mthno1)
                    .HasColumnName("MTHNO1")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Mthno2)
                    .HasColumnName("MTHNO2")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Newdon)
                    .HasColumnName("NEWDON")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Noresreq).HasColumnName("NORESREQ");

                entity.Property(e => e.Tstcnt)
                    .HasColumnName("TSTCNT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Typcd)
                    .HasColumnName("TYPCD")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dntrntbs>(entity =>
            {
                entity.HasKey(e => e.Tabname);

                entity.ToTable("DNTRNTBS");

                entity.Property(e => e.Tabname)
                    .HasColumnName("TABNAME")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Donelig>(entity =>
            {
                entity.HasKey(e => e.Eligcode);

                entity.ToTable("DONELIG");

                entity.Property(e => e.Eligcode)
                    .HasColumnName("ELIGCODE")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Eligdesc)
                    .HasColumnName("ELIGDESC")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Elignumb).HasColumnName("ELIGNUMB");
            });

            modelBuilder.Entity<Donemprm>(entity =>
            {
                entity.HasKey(e => new { e.Proctype, e.Proccode, e.Aborh, e.Mnemonic });

                entity.ToTable("DONEMPRM");

                entity.Property(e => e.Proctype)
                    .HasColumnName("PROCTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Proccode)
                    .HasColumnName("PROCCODE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Aborh)
                    .HasColumnName("ABORH")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Mnemonic)
                    .HasColumnName("MNEMONIC")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Donmaint>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("DONMAINT");

                entity.Property(e => e.Keyword)
                    .HasColumnName("KEYWORD")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Donparam)
                    .HasColumnName("DONPARAM")
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Donrfddl>(entity =>
            {
                entity.HasKey(e => new { e.Ddlcode, e.Ddlord });

                entity.ToTable("DONRFDDL");

                entity.Property(e => e.Ddlcode)
                    .HasColumnName("DDLCODE")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Ddlord).HasColumnName("DDLORD");

                entity.Property(e => e.Ddlcapt)
                    .HasColumnName("DDLCAPT")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Ddltext)
                    .HasColumnName("DDLTEXT")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Formatcd)
                    .HasColumnName("FORMATCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sectncd)
                    .HasColumnName("SECTNCD")
                    .HasMaxLength(9)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Donrfedt>(entity =>
            {
                entity.HasKey(e => e.Edtcode);

                entity.ToTable("DONRFEDT");

                entity.Property(e => e.Edtcode)
                    .HasColumnName("EDTCODE")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Edtcapt)
                    .HasColumnName("EDTCAPT")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Edthint)
                    .HasColumnName("EDTHINT")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Edtname)
                    .HasColumnName("EDTNAME")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Edttype)
                    .HasColumnName("EDTTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Formatcd)
                    .HasColumnName("FORMATCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Ismand)
                    .HasColumnName("ISMAND")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mandgrp)
                    .HasColumnName("MANDGRP")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Showcapt)
                    .HasColumnName("SHOWCAPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Valflag)
                    .HasColumnName("VALFLAG")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Donrfeml>(entity =>
            {
                entity.HasKey(e => new { e.Rftypcd, e.Emailadd });

                entity.ToTable("DONRFEML");

                entity.Property(e => e.Rftypcd)
                    .HasColumnName("RFTYPCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Emailadd)
                    .HasColumnName("EMAILADD")
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Donrffrm>(entity =>
            {
                entity.HasKey(e => e.Formatcd);

                entity.ToTable("DONRFFRM");

                entity.Property(e => e.Formatcd)
                    .HasColumnName("FORMATCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Colourcd)
                    .HasColumnName("COLOURCD")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Font)
                    .HasColumnName("FONT")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Isbold)
                    .HasColumnName("ISBOLD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Isitalic)
                    .HasColumnName("ISITALIC")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Isunderl)
                    .HasColumnName("ISUNDERL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Textsize).HasColumnName("TEXTSIZE");
            });

            modelBuilder.Entity<Donrflnk>(entity =>
            {
                entity.HasKey(e => new { e.Rftypcd, e.Rfrspcd });

                entity.ToTable("DONRFLNK");

                entity.Property(e => e.Rftypcd)
                    .HasColumnName("RFTYPCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rfrspcd)
                    .HasColumnName("RFRSPCD")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Donrfprp>(entity =>
            {
                entity.HasKey(e => e.Promptcd);

                entity.ToTable("DONRFPRP");

                entity.Property(e => e.Promptcd)
                    .HasColumnName("PROMPTCD")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Formatcd)
                    .HasColumnName("FORMATCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Prptext)
                    .HasColumnName("PRPTEXT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Donrfrad>(entity =>
            {
                entity.HasKey(e => new { e.Radcode, e.Radord });

                entity.ToTable("DONRFRAD");

                entity.Property(e => e.Radcode)
                    .HasColumnName("RADCODE")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Radord).HasColumnName("RADORD");

                entity.Property(e => e.Formatcd)
                    .HasColumnName("FORMATCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Radcapt)
                    .HasColumnName("RADCAPT")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Radtext)
                    .HasColumnName("RADTEXT")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Sectncd)
                    .HasColumnName("SECTNCD")
                    .HasMaxLength(9)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Donrfrsp>(entity =>
            {
                entity.HasKey(e => e.Rfrspcd);

                entity.ToTable("DONRFRSP");

                entity.Property(e => e.Rfrspcd)
                    .HasColumnName("RFRSPCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rfrspds)
                    .HasColumnName("RFRSPDS")
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Donrfsec>(entity =>
            {
                entity.HasKey(e => new { e.Sectncd, e.Sectnord });

                entity.ToTable("DONRFSEC");

                entity.Property(e => e.Sectncd)
                    .HasColumnName("SECTNCD")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Sectnord).HasColumnName("SECTNORD");

                entity.Property(e => e.Sectnopt)
                    .HasColumnName("SECTNOPT")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Sectntyp)
                    .HasColumnName("SECTNTYP")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Donrfsum>(entity =>
            {
                entity.HasKey(e => e.Summcode);

                entity.ToTable("DONRFSUM");

                entity.Property(e => e.Summcode)
                    .HasColumnName("SUMMCODE")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Comcatcd)
                    .HasColumnName("COMCATCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Dsgoutcd)
                    .HasColumnName("DSGOUTCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Formatcd)
                    .HasColumnName("FORMATCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Isdupdon)
                    .HasColumnName("ISDUPDON")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Notfyref)
                    .HasColumnName("NOTFYREF")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rshcd)
                    .HasColumnName("RSHCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Summtext)
                    .HasColumnName("SUMMTEXT")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Donrftyp>(entity =>
            {
                entity.HasKey(e => e.Rftypcd);

                entity.ToTable("DONRFTYP");

                entity.Property(e => e.Rftypcd)
                    .HasColumnName("RFTYPCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Emailadd)
                    .HasColumnName("EMAILADD")
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Emailado)
                    .HasColumnName("EMAILADO")
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nonuse)
                    .HasColumnName("NONUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Ordnum).HasColumnName("ORDNUM");

                entity.Property(e => e.Rftypds)
                    .HasColumnName("RFTYPDS")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Seccoddi)
                    .HasColumnName("SECCODDI")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Seccoddo)
                    .HasColumnName("SECCODDO")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Seccodni)
                    .HasColumnName("SECCODNI")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Seccodno)
                    .HasColumnName("SECCODNO")
                    .HasMaxLength(9)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dseldate>(entity =>
            {
                entity.HasKey(e => new { e.Dnsltmcd, e.Strtdate, e.Enddate, e.Pntycd, e.Procsite });

                entity.ToTable("DSELDATE");

                entity.Property(e => e.Dnsltmcd)
                    .HasColumnName("DNSLTMCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Strtdate)
                    .HasColumnName("STRTDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Enddate)
                    .HasColumnName("ENDDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Pntycd)
                    .HasColumnName("PNTYCD")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Procsite)
                    .HasColumnName("PROCSITE")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dselsrce>(entity =>
            {
                entity.HasKey(e => e.Dnkeywrd);

                entity.ToTable("DSELSRCE");

                entity.Property(e => e.Dnkeywrd)
                    .HasColumnName("DNKEYWRD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Coleval2)
                    .HasColumnName("COLEVAL2")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Coleval3)
                    .HasColumnName("COLEVAL3")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Coltext1)
                    .HasColumnName("COLTEXT1")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Coltext2)
                    .HasColumnName("COLTEXT2")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Coltext3)
                    .HasColumnName("COLTEXT3")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Columnm1)
                    .HasColumnName("COLUMNM1")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Columnm2)
                    .HasColumnName("COLUMNM2")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Columnm3)
                    .HasColumnName("COLUMNM3")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Datatyp1)
                    .HasColumnName("DATATYP1")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Datatyp2)
                    .HasColumnName("DATATYP2")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Datatyp3)
                    .HasColumnName("DATATYP3")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Menutext)
                    .HasColumnName("MENUTEXT")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Querytyp)
                    .HasColumnName("QUERYTYP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Selparlm).HasColumnName("SELPARLM");

                entity.Property(e => e.Sqlstmnt)
                    .HasColumnName("SQLSTMNT")
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Tablenm1)
                    .HasColumnName("TABLENM1")
                    .HasMaxLength(16)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dseltab>(entity =>
            {
                entity.HasKey(e => e.Tabname);

                entity.ToTable("DSELTAB");

                entity.Property(e => e.Tabname)
                    .HasColumnName("TABNAME")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dseltmpl>(entity =>
            {
                entity.HasKey(e => e.Dnsltmcd);

                entity.ToTable("DSELTMPL");

                entity.Property(e => e.Dnsltmcd)
                    .HasColumnName("DNSLTMCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Dnsltmds)
                    .HasColumnName("DNSLTMDS")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dseltmrl>(entity =>
            {
                entity.HasKey(e => new { e.Dnsltmcd, e.Dnslrule, e.Dnkeywrd });

                entity.ToTable("DSELTMRL");

                entity.Property(e => e.Dnsltmcd)
                    .HasColumnName("DNSLTMCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Dnslrule).HasColumnName("DNSLRULE");

                entity.Property(e => e.Dnkeywrd)
                    .HasColumnName("DNKEYWRD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Enrlrate)
                    .HasColumnName("ENRLRATE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Exisrate)
                    .HasColumnName("EXISRATE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Selcon1)
                    .HasColumnName("SELCON1")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Selcon2)
                    .HasColumnName("SELCON2")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Selcon3)
                    .HasColumnName("SELCON3")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Selval1)
                    .HasColumnName("SELVAL1")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Selval2)
                    .HasColumnName("SELVAL2")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Selval3)
                    .HasColumnName("SELVAL3")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Sqlorder)
                    .HasColumnName("SQLORDER")
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.Usepool)
                    .HasColumnName("USEPOOL")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dttype>(entity =>
            {
                entity.HasKey(e => new { e.Dtsyscd, e.Dtincty });

                entity.ToTable("DTTYPE");

                entity.Property(e => e.Dtsyscd)
                    .HasColumnName("DTSYSCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Dtincty)
                    .HasColumnName("DTINCTY")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Datprmpt)
                    .HasColumnName("DATPRMPT")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Inctyds)
                    .HasColumnName("INCTYDS")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Lrule)
                    .HasColumnName("LRULE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Prio).HasColumnName("PRIO");

                entity.Property(e => e.Valtype)
                    .HasColumnName("VALTYPE")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Emaildet>(entity =>
            {
                entity.HasKey(e => new { e.Commscd, e.Langcode });

                entity.ToTable("EMAILDET");

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Langcode)
                    .HasColumnName("LANGCODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Htmlfile)
                    .HasColumnName("HTMLFILE")
                    .HasMaxLength(300)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Emailkey>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("EMAILKEY");

                entity.Property(e => e.Keyword)
                    .HasColumnName("KEYWORD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Dayno).HasColumnName("DAYNO");

                entity.Property(e => e.Dbcolumn)
                    .HasColumnName("DBCOLUMN")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Dbtable)
                    .HasColumnName("DBTABLE")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Fixordb)
                    .HasColumnName("FIXORDB")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Isdate)
                    .HasColumnName("ISDATE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Istime)
                    .HasColumnName("ISTIME")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Keywdesc)
                    .HasColumnName("KEYWDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Subsys)
                    .HasColumnName("SUBSYS")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Emaladdr>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Centre });

                entity.ToTable("EMALADDR");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Centre)
                    .HasColumnName("CENTRE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(40)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Errcode>(entity =>
            {
                entity.HasKey(e => e.Errcode1);

                entity.ToTable("ERRCODE");

                entity.Property(e => e.Errcode1)
                    .HasColumnName("ERRCODE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Auditcd)
                    .HasColumnName("AUDITCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Beepset)
                    .HasColumnName("BEEPSET")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Cleartxt)
                    .HasColumnName("CLEARTXT")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Errmess)
                    .HasColumnName("ERRMESS")
                    .IsUnicode(false);

                entity.Property(e => e.Errmstyp)
                    .HasColumnName("ERRMSTYP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Techmess)
                    .HasColumnName("TECHMESS")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ethcats>(entity =>
            {
                entity.HasKey(e => e.Ethcatcd);

                entity.ToTable("ETHCATS");

                entity.Property(e => e.Ethcatcd)
                    .HasColumnName("ETHCATCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Dispord).HasColumnName("DISPORD");

                entity.Property(e => e.Ethcatds)
                    .HasColumnName("ETHCATDS")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ethorig>(entity =>
            {
                entity.HasKey(e => e.Ethcd);

                entity.ToTable("ETHORIG");

                entity.Property(e => e.Ethcd)
                    .HasColumnName("ETHCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Dispord).HasColumnName("DISPORD");

                entity.Property(e => e.Ethcatcd)
                    .HasColumnName("ETHCATCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Ethdesc)
                    .HasColumnName("ETHDESC")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Ethdescw)
                    .HasColumnName("ETHDESCW")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Exccall>(entity =>
            {
                entity.HasKey(e => e.Exccd);

                entity.ToTable("EXCCALL");

                entity.Property(e => e.Exccd)
                    .HasColumnName("EXCCD")
                    .ValueGeneratedNever();

                entity.Property(e => e.Excds)
                    .HasColumnName("EXCDS")
                    .HasMaxLength(25)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Fctcon>(entity =>
            {
                entity.HasKey(e => new { e.Fct1, e.Fct2, e.Fct3, e.Fct4, e.Fct5, e.Fct6 });

                entity.ToTable("FCTCON");

                entity.Property(e => e.Fct1)
                    .HasColumnName("FCT1")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Fct2)
                    .HasColumnName("FCT2")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Fct3)
                    .HasColumnName("FCT3")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Fct4)
                    .HasColumnName("FCT4")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Fct5)
                    .HasColumnName("FCT5")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Fct6)
                    .HasColumnName("FCT6")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Fct126)
                    .HasColumnName("FCT126")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Fct126a)
                    .HasColumnName("FCT126A")
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Gcselect>(entity =>
            {
                entity.HasKey(e => e.Gckeywrd);

                entity.ToTable("GCSELECT");

                entity.Property(e => e.Gckeywrd)
                    .HasColumnName("GCKEYWRD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Gcdesc)
                    .HasColumnName("GCDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Gcinuse)
                    .HasColumnName("GCINUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Hapostcd>(entity =>
            {
                entity.HasKey(e => new { e.Postarea, e.Haarea });

                entity.ToTable("HAPOSTCD");

                entity.Property(e => e.Postarea)
                    .HasColumnName("POSTAREA")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Haarea)
                    .HasColumnName("HAAREA")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Areaname)
                    .HasColumnName("AREANAME")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Nhsnoreq).HasColumnName("NHSNOREQ");
            });

            modelBuilder.Entity<Helphnts>(entity =>
            {
                entity.HasKey(e => new { e.Reftblnm, e.Reftblcd });

                entity.ToTable("HELPHNTS");

                entity.Property(e => e.Reftblnm)
                    .HasColumnName("REFTBLNM")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Reftblcd)
                    .HasColumnName("REFTBLCD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Hinttext)
                    .HasColumnName("HINTTEXT")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Holddept>(entity =>
            {
                entity.HasKey(e => new { e.Rshcd, e.Rshty, e.Sitcd, e.Deptcode, e.Actavail });

                entity.ToTable("HOLDDEPT");

                entity.Property(e => e.Rshcd)
                    .HasColumnName("RSHCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rshty)
                    .HasColumnName("RSHTY")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Deptcode)
                    .HasColumnName("DEPTCODE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Actavail)
                    .HasColumnName("ACTAVAIL")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Isoctry>(entity =>
            {
                entity.HasKey(e => e.Ctrycode);

                entity.ToTable("ISOCTRY");

                entity.Property(e => e.Ctrycode)
                    .HasColumnName("CTRYCODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Ctrydesc)
                    .HasColumnName("CTRYDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Defercd)
                    .HasColumnName("DEFERCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Jobdays>(entity =>
            {
                entity.HasKey(e => e.Jobid);

                entity.ToTable("JOBDAYS");

                entity.Property(e => e.Jobid)
                    .HasColumnName("JOBID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Fri)
                    .HasColumnName("FRI")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mon)
                    .HasColumnName("MON")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sat)
                    .HasColumnName("SAT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sun)
                    .HasColumnName("SUN")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Thu)
                    .HasColumnName("THU")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tue)
                    .HasColumnName("TUE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Wed)
                    .HasColumnName("WED")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Jobname>(entity =>
            {
                entity.HasKey(e => e.Jobid);

                entity.ToTable("JOBNAME");

                entity.Property(e => e.Jobid)
                    .HasColumnName("JOBID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Comid)
                    .HasColumnName("COMID")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Dayfilter)
                    .HasColumnName("DAYFILTER")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Increment).HasColumnName("INCREMENT");

                entity.Property(e => e.Jobname1)
                    .HasColumnName("JOBNAME")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Maxretry).HasColumnName("MAXRETRY");

                entity.Property(e => e.Permanent)
                    .HasColumnName("PERMANENT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Quename)
                    .HasColumnName("QUENAME")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Retryfail)
                    .HasColumnName("RETRYFAIL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Xmldata)
                    .HasColumnName("XMLDATA")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<L62ref>(entity =>
            {
                entity.HasKey(e => new { e.Sitcd, e.Bchcd });

                entity.ToTable("L62REF");

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Bchcd)
                    .HasColumnName("BCHCD")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Column).HasColumnName("COLUMN");

                entity.Property(e => e.Prlabel)
                    .HasColumnName("PRLABEL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Row).HasColumnName("ROW");
            });

            modelBuilder.Entity<L63ref>(entity =>
            {
                entity.HasKey(e => e.Prdty);

                entity.ToTable("L63REF");

                entity.Property(e => e.Prdty)
                    .HasColumnName("PRDTY")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Labelfit>(entity =>
            {
                entity.HasKey(e => new { e.Fontsize, e.Maxlen, e.Labelstr });

                entity.ToTable("LABELFIT");

                entity.Property(e => e.Fontsize).HasColumnName("FONTSIZE");

                entity.Property(e => e.Maxlen).HasColumnName("MAXLEN");

                entity.Property(e => e.Labelstr)
                    .HasColumnName("LABELSTR")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Strfit).HasColumnName("STRFIT");
            });

            modelBuilder.Entity<Lbmrgrle>(entity =>
            {
                entity.HasKey(e => new { e.Mergekey, e.Status1, e.Status2 });

                entity.ToTable("LBMRGRLE");

                entity.Property(e => e.Mergekey)
                    .HasColumnName("MERGEKEY")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Status1)
                    .HasColumnName("STATUS1")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Status2)
                    .HasColumnName("STATUS2")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mrgreslt)
                    .HasColumnName("MRGRESLT")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Letcancd>(entity =>
            {
                entity.HasKey(e => e.Letcancd1);

                entity.ToTable("LETCANCD");

                entity.Property(e => e.Letcancd1)
                    .HasColumnName("LETCANCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Candesc)
                    .HasColumnName("CANDESC")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Descript)
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Usersyst)
                    .HasColumnName("USERSYST")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Maildet>(entity =>
            {
                entity.HasKey(e => e.Doccode);

                entity.ToTable("MAILDET");

                entity.Property(e => e.Doccode)
                    .HasColumnName("DOCCODE")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Docdesc)
                    .HasColumnName("DOCDESC")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Insvalid)
                    .HasColumnName("INSVALID")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Maxlines).HasColumnName("MAXLINES");

                entity.Property(e => e.Maxtext).HasColumnName("MAXTEXT");

                entity.Property(e => e.Msgvalid)
                    .HasColumnName("MSGVALID")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mailins>(entity =>
            {
                entity.HasKey(e => e.Inscode);

                entity.ToTable("MAILINS");

                entity.Property(e => e.Inscode)
                    .HasColumnName("INSCODE")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Insdesc)
                    .HasColumnName("INSDESC")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Prio).HasColumnName("PRIO");
            });

            modelBuilder.Entity<Mailslct>(entity =>
            {
                entity.HasKey(e => new { e.Doccode, e.Doctype, e.Slctcon });

                entity.ToTable("MAILSLCT");

                entity.Property(e => e.Doccode)
                    .HasColumnName("DOCCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Doctype)
                    .HasColumnName("DOCTYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Slctcon)
                    .HasColumnName("SLCTCON")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Manident>(entity =>
            {
                entity.HasKey(e => e.Manuf);

                entity.ToTable("MANIDENT");

                entity.Property(e => e.Manuf)
                    .HasColumnName("MANUF")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Bartype)
                    .HasColumnName("BARTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Manfdesc)
                    .HasColumnName("MANFDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mergecat>(entity =>
            {
                entity.HasKey(e => e.Catcode);

                entity.ToTable("MERGECAT");

                entity.Property(e => e.Catcode)
                    .HasColumnName("CATCODE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Catdesc)
                    .HasColumnName("CATDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mergerun>(entity =>
            {
                entity.HasKey(e => new { e.Rundate, e.Mrgrunno, e.Cntcd });

                entity.ToTable("MERGERUN");

                entity.Property(e => e.Rundate)
                    .HasColumnName("RUNDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Mrgrunno)
                    .HasColumnName("MRGRUNNO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cntcd)
                    .HasColumnName("CNTCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Actperid)
                    .HasColumnName("ACTPERID")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Endtim)
                    .HasColumnName("ENDTIM")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Matchlev)
                    .HasColumnName("MATCHLEV")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Noactchk)
                    .HasColumnName("NOACTCHK")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Noactcnt).HasColumnName("NOACTCNT");

                entity.Property(e => e.Noactdup).HasColumnName("NOACTDUP");

                entity.Property(e => e.Nodonors).HasColumnName("NODONORS");

                entity.Property(e => e.Noprsact).HasColumnName("NOPRSACT");

                entity.Property(e => e.Noprsdup).HasColumnName("NOPRSDUP");

                entity.Property(e => e.Noprsreq).HasColumnName("NOPRSREQ");

                entity.Property(e => e.Norecact).HasColumnName("NORECACT");

                entity.Property(e => e.Norecdup).HasColumnName("NORECDUP");

                entity.Property(e => e.Norecreq).HasColumnName("NORECREQ");

                entity.Property(e => e.Nowthchk)
                    .HasColumnName("NOWTHCHK")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nowthcnt).HasColumnName("NOWTHCNT");

                entity.Property(e => e.Nowthdup).HasColumnName("NOWTHDUP");

                entity.Property(e => e.Prsdate)
                    .HasColumnName("PRSDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Prsperid)
                    .HasColumnName("PRSPERID")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Recdate)
                    .HasColumnName("RECDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Recperid)
                    .HasColumnName("RECPERID")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Starttim)
                    .HasColumnName("STARTTIM")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Wthperid)
                    .HasColumnName("WTHPERID")
                    .HasMaxLength(9)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mergrule>(entity =>
            {
                entity.HasKey(e => new { e.Abostat, e.Rhstat, e.Tm1stat, e.Tm2stat, e.Serostat, e.Admnstat, e.Labstat });

                entity.ToTable("MERGRULE");

                entity.Property(e => e.Abostat)
                    .HasColumnName("ABOSTAT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rhstat)
                    .HasColumnName("RHSTAT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tm1stat)
                    .HasColumnName("TM1STAT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tm2stat)
                    .HasColumnName("TM2STAT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Serostat)
                    .HasColumnName("SEROSTAT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Admnstat)
                    .HasColumnName("ADMNSTAT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Labstat)
                    .HasColumnName("LABSTAT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mrgreslt)
                    .HasColumnName("MRGRESLT")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Messdets>(entity =>
            {
                entity.HasKey(e => new { e.Msgno, e.Mnemonic, e.Langcode });

                entity.ToTable("MESSDETS");

                entity.Property(e => e.Msgno)
                    .HasColumnName("MSGNO")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Mnemonic)
                    .HasColumnName("MNEMONIC")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Langcode)
                    .HasColumnName("LANGCODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Msgtext)
                    .HasColumnName("MSGTEXT")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Tecdets)
                    .HasColumnName("TECDETS")
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Messhelp>(entity =>
            {
                entity.HasKey(e => e.Msgno);

                entity.ToTable("MESSHELP");

                entity.Property(e => e.Msgno)
                    .HasColumnName("MSGNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Allretry)
                    .HasColumnName("ALLRETRY")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Desc)
                    .HasColumnName("DESC")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Forcemes)
                    .HasColumnName("FORCEMES")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Windesc)
                    .HasColumnName("WINDESC")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Messtext>(entity =>
            {
                entity.HasKey(e => new { e.Msgno, e.Seqno });

                entity.ToTable("MESSTEXT");

                entity.Property(e => e.Msgno)
                    .HasColumnName("MSGNO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Seqno)
                    .HasColumnName("SEQNO")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Text)
                    .HasColumnName("TEXT")
                    .HasMaxLength(72)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mmfortyp>(entity =>
            {
                entity.HasKey(e => new { e.Fmtype, e.Fmdesc });

                entity.ToTable("MMFORTYP");

                entity.Property(e => e.Fmtype).HasColumnName("FMTYPE");

                entity.Property(e => e.Fmdesc)
                    .HasColumnName("FMDESC")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mobilcms>(entity =>
            {
                entity.HasKey(e => new { e.Webapp, e.Code });

                entity.ToTable("MOBILCMS");

                entity.Property(e => e.Webapp)
                    .HasColumnName("WEBAPP")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Messtext)
                    .HasColumnName("MESSTEXT")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Severity)
                    .HasColumnName("SEVERITY")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mrgcntrl>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("MRGCNTRL");

                entity.Property(e => e.Keyword)
                    .HasColumnName("KEYWORD")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Mrgparam)
                    .HasColumnName("MRGPARAM")
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mrgerrcd>(entity =>
            {
                entity.HasKey(e => e.Mrgchkcd);

                entity.ToTable("MRGERRCD");

                entity.Property(e => e.Mrgchkcd)
                    .HasColumnName("MRGCHKCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mrgchkds)
                    .HasColumnName("MRGCHKDS")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mrgfield>(entity =>
            {
                entity.HasKey(e => e.Donfield);

                entity.ToTable("MRGFIELD");

                entity.Property(e => e.Donfield)
                    .HasColumnName("DONFIELD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Colname)
                    .HasColumnName("COLNAME")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Fielddsc)
                    .HasColumnName("FIELDDSC")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Fmtype).HasColumnName("FMTYPE");

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tablenm)
                    .HasColumnName("TABLENM")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mrgprfxs>(entity =>
            {
                entity.HasKey(e => e.Prefix);

                entity.ToTable("MRGPRFXS");

                entity.Property(e => e.Prefix)
                    .HasColumnName("PREFIX")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mxdupcnt).HasColumnName("MXDUPCNT");

                entity.Property(e => e.Mxsrchtm).HasColumnName("MXSRCHTM");
            });

            modelBuilder.Entity<Mrktdept>(entity =>
            {
                entity.HasKey(e => e.Mrktcode);

                entity.ToTable("MRKTDEPT");

                entity.Property(e => e.Mrktcode)
                    .HasColumnName("MRKTCODE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mrktdesc)
                    .HasColumnName("MRKTDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mrktuser>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("MRKTUSER");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Mrktcode)
                    .HasColumnName("MRKTCODE")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mthcon>(entity =>
            {
                entity.HasKey(e => e.Bchcd);

                entity.ToTable("MTHCON");

                entity.Property(e => e.Bchcd)
                    .HasColumnName("BCHCD")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Donat)
                    .HasColumnName("DONAT")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Dondet)
                    .HasColumnName("DONDET")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mthsid>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("MTHSID");

                entity.Property(e => e.Idno)
                    .HasColumnName("IDNO")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mthsite>(entity =>
            {
                entity.HasKey(e => e.Sitcd);

                entity.ToTable("MTHSITE");

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Abot128)
                    .HasColumnName("ABOT128")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Abotitl1)
                    .HasColumnName("ABOTITL1")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Abotitl2)
                    .HasColumnName("ABOTITL2")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Addr2)
                    .HasColumnName("ADDR2")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Addr3)
                    .HasColumnName("ADDR3")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Faxno)
                    .HasColumnName("FAXNO")
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Lblabrev)
                    .HasColumnName("LBLABREV")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Lbltitle)
                    .HasColumnName("LBLTITLE")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Lhsite)
                    .HasColumnName("LHSITE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Postcd)
                    .HasColumnName("POSTCD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Psitcd)
                    .HasColumnName("PSITCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Telno)
                    .HasColumnName("TELNO")
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Namevar>(entity =>
            {
                entity.HasKey(e => new { e.Varnum, e.Varname });

                entity.ToTable("NAMEVAR");

                entity.Property(e => e.Varnum).HasColumnName("VARNUM");

                entity.Property(e => e.Varname)
                    .HasColumnName("VARNAME")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ncccolor>(entity =>
            {
                entity.HasKey(e => new { e.Nccdate, e.Aborh });

                entity.ToTable("NCCCOLOR");

                entity.Property(e => e.Nccdate)
                    .HasColumnName("NCCDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Aborh)
                    .HasColumnName("ABORH")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Backclr)
                    .HasColumnName("BACKCLR")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Foreclr)
                    .HasColumnName("FORECLR")
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Nggrconv>(entity =>
            {
                entity.HasKey(e => e.Osnatgrd);

                entity.ToTable("NGGRCONV");

                entity.Property(e => e.Osnatgrd)
                    .HasColumnName("OSNATGRD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Eastofst).HasColumnName("EASTOFST");

                entity.Property(e => e.Nrthofst).HasColumnName("NRTHOFST");
            });

            modelBuilder.Entity<Nhsiaref>(entity =>
            {
                entity.HasKey(e => new { e.Modnam, e.Code });

                entity.ToTable("NHSIAREF");

                entity.Property(e => e.Modnam)
                    .HasColumnName("MODNAM")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Nmresdsp>(entity =>
            {
                entity.HasKey(e => new { e.Proccode, e.Bchcd });

                entity.ToTable("NMRESDSP");

                entity.Property(e => e.Proccode)
                    .HasColumnName("PROCCODE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Bchcd)
                    .HasColumnName("BCHCD")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Relpos).HasColumnName("RELPOS");
            });

            modelBuilder.Entity<Nonsescm>(entity =>
            {
                entity.HasKey(e => e.Commscd);

                entity.ToTable("NONSESCM");

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Groupdur).HasColumnName("GROUPDUR");

                entity.Property(e => e.Groupreq)
                    .HasColumnName("GROUPREQ")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Microdur).HasColumnName("MICRODUR");

                entity.Property(e => e.Microreq)
                    .HasColumnName("MICROREQ")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nccuse)
                    .HasColumnName("NCCUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Pantyp)
                    .HasColumnName("PANTYP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Pcinuse)
                    .HasColumnName("PCINUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ooasuppl>(entity =>
            {
                entity.HasKey(e => e.Ctrycode);

                entity.ToTable("OOASUPPL");

                entity.Property(e => e.Ctrycode)
                    .HasColumnName("CTRYCODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Pstmess1)
                    .HasColumnName("PSTMESS1")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Pstmess2)
                    .HasColumnName("PSTMESS2")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Pstmess3)
                    .HasColumnName("PSTMESS3")
                    .HasMaxLength(60)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Osdate>(entity =>
            {
                entity.HasKey(e => e.Pulsdate);

                entity.ToTable("OSDATE");

                entity.Property(e => e.Pulsdate)
                    .HasColumnName("PULSDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Dateno).HasColumnName("DATENO");
            });

            modelBuilder.Entity<Panref>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("PANREF");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pcklot>(entity =>
            {
                entity.HasKey(e => new { e.Lotno, e.Pckcod, e.Datrec, e.Timrec, e.Sitcd });

                entity.ToTable("PCKLOT");

                entity.Property(e => e.Lotno)
                    .HasColumnName("LOTNO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Pckcod)
                    .HasColumnName("PCKCOD")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Datrec)
                    .HasColumnName("DATREC")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Timrec)
                    .HasColumnName("TIMREC")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Barctype)
                    .HasColumnName("BARCTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Expdat)
                    .HasColumnName("EXPDAT")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Manuf)
                    .HasColumnName("MANUF")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Nount).HasColumnName("NOUNT");

                entity.Property(e => e.Packadd)
                    .HasColumnName("PACKADD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pcktyp>(entity =>
            {
                entity.HasKey(e => e.Pckcod);

                entity.ToTable("PCKTYP");

                entity.Property(e => e.Pckcod)
                    .HasColumnName("PCKCOD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Codeprio).HasColumnName("CODEPRIO");

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Pckdes)
                    .HasColumnName("PCKDES")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Pckdesw)
                    .HasColumnName("PCKDESW")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Rsrvcode)
                    .HasColumnName("RSRVCODE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pcl70ref>(entity =>
            {
                entity.HasKey(e => new { e.Sitcd, e.Labcd, e.Bchcd });

                entity.ToTable("PCL70REF");

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Labcd)
                    .HasColumnName("LABCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Bchcd)
                    .HasColumnName("BCHCD")
                    .HasMaxLength(5)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Phonekey>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("PHONEKEY");

                entity.Property(e => e.Keyword)
                    .HasColumnName("KEYWORD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Dayno).HasColumnName("DAYNO");

                entity.Property(e => e.Dbcolumn)
                    .HasColumnName("DBCOLUMN")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Dbtable)
                    .HasColumnName("DBTABLE")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Fixordb)
                    .HasColumnName("FIXORDB")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Isdate)
                    .HasColumnName("ISDATE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Istime)
                    .HasColumnName("ISTIME")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Keywdesc)
                    .HasColumnName("KEYWDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Maxlen).HasColumnName("MAXLEN");

                entity.Property(e => e.Smsavail)
                    .HasColumnName("SMSAVAIL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Subsys)
                    .HasColumnName("SUBSYS")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Telavail)
                    .HasColumnName("TELAVAIL")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Placegrid>(entity =>
            {
                entity.HasKey(e => e.Mapseq);

                entity.ToTable("PLACEGRID");

                entity.Property(e => e.Mapseq)
                    .HasColumnName("MAPSEQ")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoCode)
                    .HasColumnName("CO_CODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.County)
                    .HasColumnName("COUNTY")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Ctrycode)
                    .HasColumnName("CTRYCODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.DefNam)
                    .HasColumnName("DEF_NAM")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.EDate)
                    .HasColumnName("E_DATE")
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.East).HasColumnName("EAST");

                entity.Property(e => e.FCode)
                    .HasColumnName("F_CODE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.FullCounty)
                    .HasColumnName("FULL_COUNTY")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Gmt)
                    .HasColumnName("GMT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.KmRef)
                    .HasColumnName("KM_REF")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.LatDeg).HasColumnName("LAT_DEG");

                entity.Property(e => e.LatMin)
                    .HasColumnName("LAT_MIN")
                    .HasColumnType("decimal(3, 1)");

                entity.Property(e => e.LongDeg).HasColumnName("LONG_DEG");

                entity.Property(e => e.LongMin)
                    .HasColumnName("LONG_MIN")
                    .HasColumnType("decimal(3, 1)");

                entity.Property(e => e.North).HasColumnName("NORTH");

                entity.Property(e => e.Sheet1).HasColumnName("SHEET_1");

                entity.Property(e => e.Sheet2).HasColumnName("SHEET_2");

                entity.Property(e => e.Sheet3).HasColumnName("SHEET_3");

                entity.Property(e => e.TileRef)
                    .HasColumnName("TILE_REF")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.UcdefNam)
                    .HasColumnName("UCDEF_NAM")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.UpdateCo)
                    .HasColumnName("UPDATE_CO")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pltran>(entity =>
            {
                entity.HasKey(e => e.Prdcd);

                entity.ToTable("PLTRAN");

                entity.Property(e => e.Prdcd)
                    .HasColumnName("PRDCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Bplpsc)
                    .HasColumnName("BPLPSC")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Pltype)
                    .HasColumnName("PLTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pntychk>(entity =>
            {
                entity.HasKey(e => new { e.Pntycd, e.Valvals });

                entity.ToTable("PNTYCHK");

                entity.Property(e => e.Pntycd)
                    .HasColumnName("PNTYCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Valvals)
                    .HasColumnName("VALVALS")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Daycount).HasColumnName("DAYCOUNT");

                entity.Property(e => e.Daydir)
                    .HasColumnName("DAYDIR")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Postrate>(entity =>
            {
                entity.HasKey(e => e.Ratecd);

                entity.ToTable("POSTRATE");

                entity.Property(e => e.Ratecd)
                    .HasColumnName("RATECD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Ratedsc)
                    .HasColumnName("RATEDSC")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Prncmnd>(entity =>
            {
                entity.HasKey(e => new { e.Prntype, e.Prnfunc, e.Seq });

                entity.ToTable("PRNCMND");

                entity.Property(e => e.Prntype)
                    .HasColumnName("PRNTYPE")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Prnfunc)
                    .HasColumnName("PRNFUNC")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Seq).HasColumnName("SEQ");

                entity.Property(e => e.Prncode).HasColumnName("PRNCODE");
            });

            modelBuilder.Entity<Procint>(entity =>
            {
                entity.HasKey(e => new { e.Proccod1, e.Proccod2, e.Gender });

                entity.ToTable("PROCINT");

                entity.Property(e => e.Proccod1)
                    .HasColumnName("PROCCOD1")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Proccod2)
                    .HasColumnName("PROCCOD2")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Interint).HasColumnName("INTERINT");
            });

            modelBuilder.Entity<Proclink>(entity =>
            {
                entity.HasKey(e => new { e.Mastproc, e.Linkproc });

                entity.ToTable("PROCLINK");

                entity.Property(e => e.Mastproc)
                    .HasColumnName("MASTPROC")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Linkproc)
                    .HasColumnName("LINKPROC")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Procsub>(entity =>
            {
                entity.HasKey(e => new { e.Mastproc, e.Subproc });

                entity.ToTable("PROCSUB");

                entity.Property(e => e.Mastproc)
                    .HasColumnName("MASTPROC")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Subproc)
                    .HasColumnName("SUBPROC")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Prodcell>(entity =>
            {
                entity.HasKey(e => new { e.Sitcd, e.Prcellcd });

                entity.ToTable("PRODCELL");

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Prcellcd)
                    .HasColumnName("PRCELLCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Prcellds)
                    .HasColumnName("PRCELLDS")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Prodct>(entity =>
            {
                entity.HasKey(e => e.Prdcd);

                entity.ToTable("PRODCT");

                entity.Property(e => e.Prdcd)
                    .HasColumnName("PRDCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Addtpreq)
                    .HasColumnName("ADDTPREQ")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Aphprod)
                    .HasColumnName("APHPROD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Bchrq)
                    .HasColumnName("BCHRQ")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Bctscrn)
                    .HasColumnName("BCTSCRN")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Conwght).HasColumnName("CONWGHT");

                entity.Property(e => e.Density).HasColumnName("DENSITY");

                entity.Property(e => e.Dfstk)
                    .HasColumnName("DFSTK")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Disclab)
                    .HasColumnName("DISCLAB")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Dself)
                    .HasColumnName("DSELF")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Extrproc)
                    .HasColumnName("EXTRPROC")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Grpfl)
                    .HasColumnName("GRPFL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Grspc)
                    .HasColumnName("GRSPC")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Initstat)
                    .HasColumnName("INITSTAT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inttwoyr)
                    .HasColumnName("INTTWOYR")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Irrchk)
                    .HasColumnName("IRRCHK")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Isscomm)
                    .HasColumnName("ISSCOMM")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Labelty)
                    .HasColumnName("LABELTY")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Life)
                    .HasColumnName("LIFE")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Lifhh)
                    .HasColumnName("LIFHH")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mgrpcd)
                    .HasColumnName("MGRPCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Microreq)
                    .HasColumnName("MICROREQ")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Newprd)
                    .HasColumnName("NEWPRD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nominal).HasColumnName("NOMINAL");

                entity.Property(e => e.Overnom)
                    .HasColumnName("OVERNOM")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Pckgwght).HasColumnName("PCKGWGHT");

                entity.Property(e => e.Prdsl)
                    .HasColumnName("PRDSL")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Prdss)
                    .HasColumnName("PRDSS")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Prdsw)
                    .HasColumnName("PRDSW")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Prdty)
                    .HasColumnName("PRDTY")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Prfit)
                    .HasColumnName("PRFIT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Recwght)
                    .HasColumnName("RECWGHT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rtextexp)
                    .HasColumnName("RTEXTEXP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Superrpt)
                    .HasColumnName("SUPERRPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Timscl)
                    .HasColumnName("TIMSCL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tisshslb).HasColumnName("TISSHSLB");

                entity.Property(e => e.Tobpl)
                    .HasColumnName("TOBPL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Units)
                    .HasColumnName("UNITS")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Warntime).HasColumnName("WARNTIME");

                entity.Property(e => e.Warnunit)
                    .HasColumnName("WARNUNIT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Wndexbar)
                    .HasColumnName("WNDEXBAR")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Provdets>(entity =>
            {
                entity.HasKey(e => e.Prvider);

                entity.ToTable("PROVDETS");

                entity.Property(e => e.Prvider)
                    .HasColumnName("PRVIDER")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Destaddr)
                    .HasColumnName("DESTADDR")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Destdir)
                    .HasColumnName("DESTDIR")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Ftpact)
                    .HasColumnName("FTPACT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Ftpdtype)
                    .HasColumnName("FTPDTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Ftppass)
                    .HasColumnName("FTPPASS")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Ftpuser)
                    .HasColumnName("FTPUSER")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Prvdesc)
                    .HasColumnName("PRVDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pstcdupd>(entity =>
            {
                entity.HasKey(e => new { e.Ptable, e.Pcolumn });

                entity.ToTable("PSTCDUPD");

                entity.Property(e => e.Ptable)
                    .HasColumnName("PTABLE")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Pcolumn)
                    .HasColumnName("PCOLUMN")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Keycol1)
                    .HasColumnName("KEYCOL1")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Keycol2)
                    .HasColumnName("KEYCOL2")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Keycol3)
                    .HasColumnName("KEYCOL3")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Keycol4)
                    .HasColumnName("KEYCOL4")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Nongeogp)
                    .HasColumnName("NONGEOGP")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ptypbch>(entity =>
            {
                entity.HasKey(e => new { e.Pckcod, e.Bchcd });

                entity.ToTable("PTYPBCH");

                entity.Property(e => e.Pckcod)
                    .HasColumnName("PCKCOD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Bchcd)
                    .HasColumnName("BCHCD")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Reseval)
                    .HasColumnName("RESEVAL")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Reslt)
                    .HasColumnName("RESLT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tsource)
                    .HasColumnName("TSOURCE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pulsedb>(entity =>
            {
                entity.HasKey(e => e.Dbnamecd);

                entity.ToTable("PULSEDB");

                entity.Property(e => e.Dbnamecd)
                    .HasColumnName("DBNAMECD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Dbnameds)
                    .HasColumnName("DBNAMEDS")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Dbtype)
                    .HasColumnName("DBTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pulsrprt>(entity =>
            {
                entity.HasKey(e => new { e.Funcname, e.Sitcd, e.Loccd });

                entity.ToTable("PULSRPRT");

                entity.Property(e => e.Funcname)
                    .HasColumnName("FUNCNAME")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Loccd)
                    .HasColumnName("LOCCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Emailrpt)
                    .HasColumnName("EMAILRPT")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Netprntr)
                    .HasColumnName("NETPRNTR")
                    .HasMaxLength(150)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Q46cntrl>(entity =>
            {
                entity.HasKey(e => new { e.Centre, e.Runno });

                entity.ToTable("Q46CNTRL");

                entity.Property(e => e.Centre)
                    .HasColumnName("CENTRE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Runno).HasColumnName("RUNNO");

                entity.Property(e => e.Daydate)
                    .HasColumnName("DAYDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Usechktm)
                    .HasColumnName("USECHKTM")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Qcodes>(entity =>
            {
                entity.HasKey(e => e.Qcode);

                entity.ToTable("QCODES");

                entity.Property(e => e.Qcode)
                    .HasColumnName("QCODE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Qdesc)
                    .HasColumnName("QDESC")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Qjobs>(entity =>
            {
                entity.HasKey(e => e.Entryid);

                entity.ToTable("QJOBS");

                entity.Property(e => e.Entryid)
                    .HasColumnName("ENTRYID")
                    .HasMaxLength(38)
                    .IsFixedLength();

                entity.Property(e => e.Errdata)
                    .HasColumnName("ERRDATA")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Errentryid)
                    .HasColumnName("ERRENTRYID")
                    .HasMaxLength(38)
                    .IsFixedLength();

                entity.Property(e => e.Jobdata)
                    .HasColumnName("JOBDATA")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Jobend)
                    .HasColumnName("JOBEND")
                    .HasColumnType("datetime");

                entity.Property(e => e.Jobid)
                    .HasColumnName("JOBID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Jobstart)
                    .HasColumnName("JOBSTART")
                    .HasColumnType("datetime");

                entity.Property(e => e.Msgid).HasColumnName("MSGID");

                entity.Property(e => e.Noretry).HasColumnName("NORETRY");

                entity.Property(e => e.Qcode)
                    .HasColumnName("QCODE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Qoverride)
                    .HasColumnName("QOVERRIDE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Quename)
                    .HasColumnName("QUENAME")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Realstart)
                    .HasColumnName("REALSTART")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Quename>(entity =>
            {
                entity.HasKey(e => e.Quename1);

                entity.ToTable("QUENAME");

                entity.Property(e => e.Quename1)
                    .HasColumnName("QUENAME")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Joblimit).HasColumnName("JOBLIMIT");

                entity.Property(e => e.Questarted)
                    .HasColumnName("QUESTARTED")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Retryque)
                    .HasColumnName("RETRYQUE")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Server)
                    .HasColumnName("SERVER")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Queueref>(entity =>
            {
                entity.HasKey(e => new { e.Jobname, e.Centre });

                entity.ToTable("QUEUEREF");

                entity.Property(e => e.Jobname)
                    .HasColumnName("JOBNAME")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Centre)
                    .HasColumnName("CENTRE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Qprio).HasColumnName("QPRIO");

                entity.Property(e => e.Queuenam)
                    .HasColumnName("QUEUENAM")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Runame)
                    .HasColumnName("RUNAME")
                    .HasMaxLength(39)
                    .IsFixedLength();

                entity.Property(e => e.Runtime)
                    .HasColumnName("RUNTIME")
                    .HasMaxLength(24)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Recrcat>(entity =>
            {
                entity.HasKey(e => e.Rcrcatcd);

                entity.ToTable("RECRCAT");

                entity.Property(e => e.Rcrcatcd)
                    .HasColumnName("RCRCATCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Catdesc)
                    .HasColumnName("CATDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Refaudit>(entity =>
            {
                entity.HasKey(e => new { e.Reftblnm, e.Auddate, e.Audtime, e.Chngtype, e.Userid, e.Seq });

                entity.ToTable("REFAUDIT");

                entity.Property(e => e.Reftblnm)
                    .HasColumnName("REFTBLNM")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Auddate)
                    .HasColumnName("AUDDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Audtime)
                    .HasColumnName("AUDTIME")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Chngtype)
                    .HasColumnName("CHNGTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Seq).HasColumnName("SEQ");

                entity.Property(e => e.Dataaft)
                    .HasColumnName("DATAAFT")
                    .IsUnicode(false);

                entity.Property(e => e.Databef)
                    .HasColumnName("DATABEF")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Refdescn>(entity =>
            {
                entity.HasKey(e => new { e.Reftblnm, e.Colname });

                entity.ToTable("REFDESCN");

                entity.Property(e => e.Reftblnm)
                    .HasColumnName("REFTBLNM")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Colname)
                    .HasColumnName("COLNAME")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Usertext)
                    .HasColumnName("USERTEXT")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Refdonor>(entity =>
            {
                entity.HasKey(e => new { e.Centre, e.Perid });

                entity.ToTable("REFDONOR");

                entity.Property(e => e.Centre)
                    .HasColumnName("CENTRE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Perid)
                    .HasColumnName("PERID")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Addr2)
                    .HasColumnName("ADDR2")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Addr3)
                    .HasColumnName("ADDR3")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Addr4)
                    .HasColumnName("ADDR4")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Inits)
                    .HasColumnName("INITS")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Postcd)
                    .HasColumnName("POSTCD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Surnm)
                    .HasColumnName("SURNM")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Refmess>(entity =>
            {
                entity.HasKey(e => new { e.Centre, e.Msgno });

                entity.ToTable("REFMESS");

                entity.Property(e => e.Centre)
                    .HasColumnName("CENTRE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Msgno)
                    .HasColumnName("MSGNO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Line1)
                    .HasColumnName("LINE1")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Line2)
                    .HasColumnName("LINE2")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Line3)
                    .HasColumnName("LINE3")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Line4)
                    .HasColumnName("LINE4")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Line5)
                    .HasColumnName("LINE5")
                    .HasMaxLength(60)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Reftable>(entity =>
            {
                entity.HasKey(e => new { e.Reftblnm, e.Userid });

                entity.ToTable("REFTABLE");

                entity.Property(e => e.Reftblnm)
                    .HasColumnName("REFTBLNM")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Readonly)
                    .HasColumnName("READONLY")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Relcheck>(entity =>
            {
                entity.HasKey(e => new { e.Panno, e.Aborh, e.Relfct });

                entity.ToTable("RELCHECK");

                entity.Property(e => e.Panno)
                    .HasColumnName("PANNO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Aborh)
                    .HasColumnName("ABORH")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Relfct)
                    .HasColumnName("RELFCT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Numdays).HasColumnName("NUMDAYS");
            });

            modelBuilder.Entity<Reprtout>(entity =>
            {
                entity.HasKey(e => new { e.Funcname, e.Ident1, e.Value1, e.Ident2, e.Value2, e.Ident3, e.Value3 });

                entity.ToTable("REPRTOUT");

                entity.Property(e => e.Funcname)
                    .HasColumnName("FUNCNAME")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Ident1)
                    .HasColumnName("IDENT1")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Value1)
                    .HasColumnName("VALUE1")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Ident2)
                    .HasColumnName("IDENT2")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Value2)
                    .HasColumnName("VALUE2")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Ident3)
                    .HasColumnName("IDENT3")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Value3)
                    .HasColumnName("VALUE3")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Printer)
                    .HasColumnName("PRINTER")
                    .HasMaxLength(250)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Retrpool>(entity =>
            {
                entity.HasKey(e => new { e.Centre, e.Sitcd });

                entity.ToTable("RETRPOOL");

                entity.Property(e => e.Centre)
                    .HasColumnName("CENTRE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Retrstat)
                    .HasColumnName("RETRSTAT")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rptparam>(entity =>
            {
                entity.HasKey(e => new { e.Rident, e.Sitcd });

                entity.ToTable("RPTPARAM");

                entity.Property(e => e.Rident)
                    .HasColumnName("RIDENT")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Filenm)
                    .HasColumnName("FILENM")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Format)
                    .HasColumnName("FORMAT")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Rdesc)
                    .HasColumnName("RDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Rname)
                    .HasColumnName("RNAME")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Rtype)
                    .HasColumnName("RTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rpttxt>(entity =>
            {
                entity.HasKey(e => new { e.Mnemonic, e.Rident, e.Rtxtid });

                entity.ToTable("RPTTXT");

                entity.Property(e => e.Mnemonic)
                    .HasColumnName("MNEMONIC")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Rident)
                    .HasColumnName("RIDENT")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Rtxtid)
                    .HasColumnName("RTXTID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Rtxt)
                    .HasColumnName("RTXT")
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<S17odate>(entity =>
            {
                entity.HasKey(e => new { e.Centre, e.Dow });

                entity.ToTable("S17ODATE");

                entity.Property(e => e.Centre)
                    .HasColumnName("CENTRE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Dow)
                    .HasColumnName("DOW")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Outdate).HasColumnName("OUTDATE");
            });

            modelBuilder.Entity<S46ref>(entity =>
            {
                entity.HasKey(e => new { e.Centre, e.Check });

                entity.ToTable("S46REF");

                entity.Property(e => e.Centre)
                    .HasColumnName("CENTRE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Check).HasColumnName("CHECK");

                entity.Property(e => e.Checkdsc)
                    .HasColumnName("CHECKDSC")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Chktime).HasColumnName("CHKTIME");

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Samptyp>(entity =>
            {
                entity.HasKey(e => e.Smpindex);

                entity.ToTable("SAMPTYP");

                entity.Property(e => e.Smpindex)
                    .HasColumnName("SMPINDEX")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adddetq)
                    .HasColumnName("ADDDETQ")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Orgdonq)
                    .HasColumnName("ORGDONQ")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Smptypds)
                    .HasColumnName("SMPTYPDS")
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sccmslct>(entity =>
            {
                entity.HasKey(e => new { e.Cominscd, e.Cdtype, e.Sckeywrd });

                entity.ToTable("SCCMSLCT");

                entity.Property(e => e.Cominscd)
                    .HasColumnName("COMINSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Cdtype)
                    .HasColumnName("CDTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sckeywrd)
                    .HasColumnName("SCKEYWRD")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Scgenatt>(entity =>
            {
                entity.HasKey(e => new { e.Sscmtmcd, e.Sesinsat });

                entity.ToTable("SCGENATT");

                entity.Property(e => e.Sscmtmcd)
                    .HasColumnName("SSCMTMCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sesinsat)
                    .HasColumnName("SESINSAT")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sckeywrd)
                    .HasColumnName("SCKEYWRD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Selcon1)
                    .HasColumnName("SELCON1")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Selcon2)
                    .HasColumnName("SELCON2")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Selcon3)
                    .HasColumnName("SELCON3")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Selval1)
                    .HasColumnName("SELVAL1")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Selval2)
                    .HasColumnName("SELVAL2")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Selval3)
                    .HasColumnName("SELVAL3")
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Scialocn>(entity =>
            {
                entity.HasKey(e => new { e.Sesinsat, e.Comchncd });

                entity.ToTable("SCIALOCN");

                entity.Property(e => e.Sesinsat)
                    .HasColumnName("SESINSAT")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Comchncd)
                    .HasColumnName("COMCHNCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Doclocn)
                    .HasColumnName("DOCLOCN")
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Scinsatt>(entity =>
            {
                entity.HasKey(e => e.Sesinsat);

                entity.ToTable("SCINSATT");

                entity.Property(e => e.Sesinsat)
                    .HasColumnName("SESINSAT")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Insatdes)
                    .HasColumnName("INSATDES")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Scmessdsc>(entity =>
            {
                entity.HasKey(e => e.Sesmsgcd);

                entity.ToTable("SCMESSDSC");

                entity.Property(e => e.Sesmsgcd)
                    .HasColumnName("SESMSGCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Msgcddes)
                    .HasColumnName("MSGCDDES")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Scmessge>(entity =>
            {
                entity.HasKey(e => new { e.Sesmsgcd, e.Comchncd });

                entity.ToTable("SCMESSGE");

                entity.Property(e => e.Sesmsgcd)
                    .HasColumnName("SESMSGCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Comchncd)
                    .HasColumnName("COMCHNCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Messtext)
                    .HasColumnName("MESSTEXT")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Scomtmpl>(entity =>
            {
                entity.HasKey(e => e.Sscmtmcd);

                entity.ToTable("SCOMTMPL");

                entity.Property(e => e.Sscmtmcd)
                    .HasColumnName("SSCMTMCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Comchncd)
                    .HasColumnName("COMCHNCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Donorsel)
                    .HasColumnName("DONORSEL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Dsptchdt).HasColumnName("DSPTCHDT");

                entity.Property(e => e.Inboxdte).HasColumnName("INBOXDTE");

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Messprio)
                    .HasColumnName("MESSPRIO")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sendprio)
                    .HasColumnName("SENDPRIO")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sesmsgcd)
                    .HasColumnName("SESMSGCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sscmtmds)
                    .HasColumnName("SSCMTMDS")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Scpertab>(entity =>
            {
                entity.HasKey(e => e.Tabname);

                entity.ToTable("SCPERTAB");

                entity.Property(e => e.Tabname)
                    .HasColumnName("TABNAME")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Scselsrc>(entity =>
            {
                entity.HasKey(e => e.Sckeywrd);

                entity.ToTable("SCSELSRC");

                entity.Property(e => e.Sckeywrd)
                    .HasColumnName("SCKEYWRD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Col1text)
                    .HasColumnName("COL1TEXT")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Col2text)
                    .HasColumnName("COL2TEXT")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Col3text)
                    .HasColumnName("COL3TEXT")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Coleval2)
                    .HasColumnName("COLEVAL2")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Coleval3)
                    .HasColumnName("COLEVAL3")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Columnm1)
                    .HasColumnName("COLUMNM1")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Columnm2)
                    .HasColumnName("COLUMNM2")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Columnm3)
                    .HasColumnName("COLUMNM3")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Datatyp1)
                    .HasColumnName("DATATYP1")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Datatyp2)
                    .HasColumnName("DATATYP2")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Datatyp3)
                    .HasColumnName("DATATYP3")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Menutext)
                    .HasColumnName("MENUTEXT")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Querytyp)
                    .HasColumnName("QUERYTYP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Selparlm).HasColumnName("SELPARLM");

                entity.Property(e => e.Sqlstmnt)
                    .HasColumnName("SQLSTMNT")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Tablenm1)
                    .HasColumnName("TABLENM1")
                    .HasMaxLength(16)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Scslrlcn>(entity =>
            {
                entity.HasKey(e => new { e.Sscmtmcd, e.Sscmrule, e.Sckeywrd });

                entity.ToTable("SCSLRLCN");

                entity.Property(e => e.Sscmtmcd)
                    .HasColumnName("SSCMTMCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sscmrule).HasColumnName("SSCMRULE");

                entity.Property(e => e.Sckeywrd)
                    .HasColumnName("SCKEYWRD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Selcon1)
                    .HasColumnName("SELCON1")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Selcon2)
                    .HasColumnName("SELCON2")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Selcon3)
                    .HasColumnName("SELCON3")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Selval1)
                    .HasColumnName("SELVAL1")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Selval2)
                    .HasColumnName("SELVAL2")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Selval3)
                    .HasColumnName("SELVAL3")
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Scslrlia>(entity =>
            {
                entity.HasKey(e => new { e.Sscmtmcd, e.Sscmrule });

                entity.ToTable("SCSLRLIA");

                entity.Property(e => e.Sscmtmcd)
                    .HasColumnName("SSCMTMCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sscmrule).HasColumnName("SSCMRULE");

                entity.Property(e => e.Sesinsat)
                    .HasColumnName("SESINSAT")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sesmsgcd)
                    .HasColumnName("SESMSGCD")
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sctmslrl>(entity =>
            {
                entity.HasKey(e => new { e.Sscmtmcd, e.Sscmrule });

                entity.ToTable("SCTMSLRL");

                entity.Property(e => e.Sscmtmcd)
                    .HasColumnName("SSCMTMCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sscmrule).HasColumnName("SSCMRULE");

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Servpo>(entity =>
            {
                entity.HasKey(e => new { e.Sitcd, e.Scaleid });

                entity.ToTable("SERVPO");

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Scaleid)
                    .HasColumnName("SCALEID")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Balstat)
                    .HasColumnName("BALSTAT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Datcheck)
                    .HasColumnName("DATCHECK")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Deviceid)
                    .HasColumnName("DEVICEID")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Devind)
                    .HasColumnName("DEVIND")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Failreas)
                    .HasColumnName("FAILREAS")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Linefeed)
                    .HasColumnName("LINEFEED")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Prcellcd)
                    .HasColumnName("PRCELLCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Protocol)
                    .HasColumnName("PROTOCOL")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Timcheck)
                    .HasColumnName("TIMCHECK")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sesfndpt>(entity =>
            {
                entity.HasKey(e => e.Ruleno);

                entity.ToTable("SESFNDPT");

                entity.Property(e => e.Ruleno)
                    .HasColumnName("RULENO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dfltflag)
                    .HasColumnName("DFLTFLAG")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Mapsuse)
                    .HasColumnName("MAPSUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Menutext)
                    .HasColumnName("MENUTEXT")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Mobuse)
                    .HasColumnName("MOBUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nccuse)
                    .HasColumnName("NCCUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Pantypcd)
                    .HasColumnName("PANTYPCD")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Pcd06use)
                    .HasColumnName("PCD06USE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Portluse)
                    .HasColumnName("PORTLUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sestat)
                    .HasColumnName("SESTAT")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Sestypex)
                    .HasColumnName("SESTYPEX")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Stype)
                    .HasColumnName("STYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sesoutcm>(entity =>
            {
                entity.HasKey(e => e.Outcmcd);

                entity.ToTable("SESOUTCM");

                entity.Property(e => e.Outcmcd)
                    .HasColumnName("OUTCMCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Anycmpnt)
                    .HasColumnName("ANYCMPNT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Bioreprt)
                    .HasColumnName("BIOREPRT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Credits).HasColumnName("CREDITS");

                entity.Property(e => e.Hbprmpt)
                    .HasColumnName("HBPRMPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Hldprmpt)
                    .HasColumnName("HLDPRMPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Idcprmpt)
                    .HasColumnName("IDCPRMPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Insprmpt)
                    .HasColumnName("INSPRMPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Lotprmpt)
                    .HasColumnName("LOTPRMPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nbprmpt)
                    .HasColumnName("NBPRMPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Outcmbar)
                    .HasColumnName("OUTCMBAR")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Outcmdsd)
                    .HasColumnName("OUTCMDSD")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Outcmdsl)
                    .HasColumnName("OUTCMDSL")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Outcmtab)
                    .HasColumnName("OUTCMTAB")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Prcprmpt)
                    .HasColumnName("PRCPRMPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rejtype)
                    .HasColumnName("REJTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Relfct)
                    .HasColumnName("RELFCT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Smpprmpt)
                    .HasColumnName("SMPPRMPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tubprmpt)
                    .HasColumnName("TUBPRMPT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Updcredt)
                    .HasColumnName("UPDCREDT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Updtldon)
                    .HasColumnName("UPDTLDON")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Volprmpt)
                    .HasColumnName("VOLPRMPT")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sesprdcd>(entity =>
            {
                entity.HasKey(e => new { e.Proccode, e.Pckcod, e.Option, e.Prdcd });

                entity.ToTable("SESPRDCD");

                entity.Property(e => e.Proccode)
                    .HasColumnName("PROCCODE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Pckcod)
                    .HasColumnName("PCKCOD")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Option)
                    .HasColumnName("OPTION")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Prdcd)
                    .HasColumnName("PRDCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Packno)
                    .HasColumnName("PACKNO")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sesscmdt>(entity =>
            {
                entity.HasKey(e => e.Commscd);

                entity.ToTable("SESSCMDT");

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Insprio).HasColumnName("INSPRIO");

                entity.Property(e => e.Insvalid)
                    .HasColumnName("INSVALID")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Isinsert)
                    .HasColumnName("ISINSERT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Maxlines).HasColumnName("MAXLINES");

                entity.Property(e => e.Maxtext).HasColumnName("MAXTEXT");

                entity.Property(e => e.Msgvalid)
                    .HasColumnName("MSGVALID")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sessprio>(entity =>
            {
                entity.HasKey(e => new { e.Abogrp, e.Rhgrp, e.Gender });

                entity.ToTable("SESSPRIO");

                entity.Property(e => e.Abogrp)
                    .HasColumnName("ABOGRP")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rhgrp)
                    .HasColumnName("RHGRP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sessprm>(entity =>
            {
                entity.HasKey(e => new { e.Keyword, e.Keyid });

                entity.ToTable("SESSPRM");

                entity.Property(e => e.Keyword)
                    .HasColumnName("KEYWORD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Keyid).HasColumnName("KEYID");

                entity.Property(e => e.Addrev)
                    .HasColumnName("ADDREV")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Dispord).HasColumnName("DISPORD");

                entity.Property(e => e.Iddesc)
                    .HasColumnName("IDDESC")
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Ident1)
                    .HasColumnName("IDENT1")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Ident10)
                    .HasColumnName("IDENT10")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Ident2)
                    .HasColumnName("IDENT2")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Ident3)
                    .HasColumnName("IDENT3")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Ident4)
                    .HasColumnName("IDENT4")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Ident5)
                    .HasColumnName("IDENT5")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Ident6)
                    .HasColumnName("IDENT6")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Ident7)
                    .HasColumnName("IDENT7")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Ident8)
                    .HasColumnName("IDENT8")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Ident9)
                    .HasColumnName("IDENT9")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Lastran)
                    .HasColumnName("LASTRAN")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Needsack)
                    .HasColumnName("NEEDSACK")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Warndesc)
                    .HasColumnName("WARNDESC")
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Warnlev).HasColumnName("WARNLEV");
            });

            modelBuilder.Entity<Sessproc>(entity =>
            {
                entity.HasKey(e => e.Proccode);

                entity.ToTable("SESSPROC");

                entity.Property(e => e.Proccode)
                    .HasColumnName("PROCCODE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Colcode)
                    .HasColumnName("COLCODE")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Credits).HasColumnName("CREDITS");

                entity.Property(e => e.Deftime).HasColumnName("DEFTIME");

                entity.Property(e => e.Dmdef)
                    .HasColumnName("DMDEF")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Dnq1mxag).HasColumnName("DNQ1MXAG");

                entity.Property(e => e.Dnq1nmdn).HasColumnName("DNQ1NMDN");

                entity.Property(e => e.Dnq1nmyr).HasColumnName("DNQ1NMYR");

                entity.Property(e => e.Dnq1ocom)
                    .HasColumnName("DNQ1OCOM")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Dnq1odef)
                    .HasColumnName("DNQ1ODEF")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Dnq1xcom)
                    .HasColumnName("DNQ1XCOM")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Dnq1xdef)
                    .HasColumnName("DNQ1XDEF")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Dnq2mxag).HasColumnName("DNQ2MXAG");

                entity.Property(e => e.Dnq2nmdn).HasColumnName("DNQ2NMDN");

                entity.Property(e => e.Dnq2nmyr).HasColumnName("DNQ2NMYR");

                entity.Property(e => e.Dnq2ocom)
                    .HasColumnName("DNQ2OCOM")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Dnq2odef)
                    .HasColumnName("DNQ2ODEF")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Dnq2xcom)
                    .HasColumnName("DNQ2XCOM")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Dnq2xdef)
                    .HasColumnName("DNQ2XDEF")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Dnuqmnag).HasColumnName("DNUQMNAG");

                entity.Property(e => e.Dnuqmxag).HasColumnName("DNUQMXAG");

                entity.Property(e => e.Expantyp)
                    .HasColumnName("EXPANTYP")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Maxage).HasColumnName("MAXAGE");

                entity.Property(e => e.Minage).HasColumnName("MINAGE");

                entity.Property(e => e.Nccdef)
                    .HasColumnName("NCCDEF")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nccovrd)
                    .HasColumnName("NCCOVRD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nccregnr)
                    .HasColumnName("NCCREGNR")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Pcdef)
                    .HasColumnName("PCDEF")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Pretday).HasColumnName("PRETDAY");

                entity.Property(e => e.Pretocom)
                    .HasColumnName("PRETOCOM")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Pretxcom)
                    .HasColumnName("PRETXCOM")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Procdesc)
                    .HasColumnName("PROCDESC")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Proctype)
                    .HasColumnName("PROCTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rgq1mxag).HasColumnName("RGQ1MXAG");

                entity.Property(e => e.Rgq1nmdn).HasColumnName("RGQ1NMDN");

                entity.Property(e => e.Rgq1nmyr).HasColumnName("RGQ1NMYR");

                entity.Property(e => e.Rgq2mxag).HasColumnName("RGQ2MXAG");

                entity.Property(e => e.Rgq2nmdn).HasColumnName("RGQ2NMDN");

                entity.Property(e => e.Rgq2nmyr).HasColumnName("RGQ2NMYR");

                entity.Property(e => e.Rguqmnag).HasColumnName("RGUQMNAG");

                entity.Property(e => e.Rguqmxag).HasColumnName("RGUQMXAG");

                entity.Property(e => e.Somdef)
                    .HasColumnName("SOMDEF")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sessrev>(entity =>
            {
                entity.HasKey(e => new { e.Keyword, e.Keyid, e.Sessno, e.Seqno });

                entity.ToTable("SESSREV");

                entity.Property(e => e.Keyword)
                    .HasColumnName("KEYWORD")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Keyid).HasColumnName("KEYID");

                entity.Property(e => e.Sessno)
                    .HasColumnName("SESSNO")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Seqno).HasColumnName("SEQNO");

                entity.Property(e => e.Ackuser)
                    .HasColumnName("ACKUSER")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Dateent)
                    .HasColumnName("DATEENT")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Mnemonic)
                    .HasColumnName("MNEMONIC")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Parstr1)
                    .HasColumnName("PARSTR1")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Parstr2)
                    .HasColumnName("PARSTR2")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Parstr3)
                    .HasColumnName("PARSTR3")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Parstr4)
                    .HasColumnName("PARSTR4")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Parstr5)
                    .HasColumnName("PARSTR5")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Timeent)
                    .HasColumnName("TIMEENT")
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Simlist>(entity =>
            {
                entity.HasKey(e => new { e.Holdno, e.Unitno });

                entity.ToTable("SIMLIST");

                entity.Property(e => e.Holdno)
                    .HasColumnName("HOLDNO")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Unitno)
                    .HasColumnName("UNITNO")
                    .HasMaxLength(23)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sitedmnd>(entity =>
            {
                entity.HasKey(e => new { e.Sitcd, e.Strtdate, e.Enddate, e.Proccode, e.Gender });

                entity.ToTable("SITEDMND");

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Strtdate)
                    .HasColumnName("STRTDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Enddate)
                    .HasColumnName("ENDDATE")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Proccode)
                    .HasColumnName("PROCCODE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Abnegdmd).HasColumnName("ABNEGDMD");

                entity.Property(e => e.Abnegsup).HasColumnName("ABNEGSUP");

                entity.Property(e => e.Abposdmd).HasColumnName("ABPOSDMD");

                entity.Property(e => e.Abpossup).HasColumnName("ABPOSSUP");

                entity.Property(e => e.Anegdmd).HasColumnName("ANEGDMD");

                entity.Property(e => e.Anegsup).HasColumnName("ANEGSUP");

                entity.Property(e => e.Aposdmd).HasColumnName("APOSDMD");

                entity.Property(e => e.Apossup).HasColumnName("APOSSUP");

                entity.Property(e => e.Bnegdmd).HasColumnName("BNEGDMD");

                entity.Property(e => e.Bnegsup).HasColumnName("BNEGSUP");

                entity.Property(e => e.Bposdmd).HasColumnName("BPOSDMD");

                entity.Property(e => e.Bpossup).HasColumnName("BPOSSUP");

                entity.Property(e => e.Nbdmd).HasColumnName("NBDMD");

                entity.Property(e => e.Nbsup).HasColumnName("NBSUP");

                entity.Property(e => e.Onegdmd).HasColumnName("ONEGDMD");

                entity.Property(e => e.Onegsup).HasColumnName("ONEGSUP");

                entity.Property(e => e.Oposdmd).HasColumnName("OPOSDMD");

                entity.Property(e => e.Opossup).HasColumnName("OPOSSUP");
            });

            modelBuilder.Entity<Siteprm>(entity =>
            {
                entity.HasKey(e => new { e.Sitcd, e.Key1, e.Key2 });

                entity.ToTable("SITEPRM");

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Key1)
                    .HasColumnName("KEY1")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Key2)
                    .HasColumnName("KEY2")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Desc)
                    .HasColumnName("DESC")
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Param)
                    .HasColumnName("PARAM")
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sityrseq>(entity =>
            {
                entity.HasKey(e => new { e.Identkey, e.Sitcd, e.Yearno });

                entity.ToTable("SITYRSEQ");

                entity.Property(e => e.Identkey)
                    .HasColumnName("IDENTKEY")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Yearno)
                    .HasColumnName("YEARNO")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Nextseq).HasColumnName("NEXTSEQ");
            });

            modelBuilder.Entity<Smsdet>(entity =>
            {
                entity.HasKey(e => new { e.Commscd, e.Langcode });

                entity.ToTable("SMSDET");

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Langcode)
                    .HasColumnName("LANGCODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Smstext)
                    .HasColumnName("SMSTEXT")
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Teldet>(entity =>
            {
                entity.HasKey(e => new { e.Commscd, e.Langcode });

                entity.ToTable("TELDET");

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Langcode)
                    .HasColumnName("LANGCODE")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Dontext)
                    .HasColumnName("DONTEXT")
                    .IsUnicode(false);

                entity.Property(e => e.Gentext)
                    .HasColumnName("GENTEXT")
                    .IsUnicode(false);

                entity.Property(e => e.Inuse)
                    .HasColumnName("INUSE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Telnoref>(entity =>
            {
                entity.HasKey(e => e.Telnprfx);

                entity.ToTable("TELNOREF");

                entity.Property(e => e.Telnprfx)
                    .HasColumnName("TELNPRFX")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Cnvtelno)
                    .HasColumnName("CNVTELNO")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tellen).HasColumnName("TELLEN");

                entity.Property(e => e.Teltext)
                    .HasColumnName("TELTEXT")
                    .HasMaxLength(40)
                    .IsFixedLength();
            });

            modelBuilder.Entity<U06ref>(entity =>
            {
                entity.HasKey(e => new { e.Sitcd, e.Fprdcd });

                entity.ToTable("U06REF");

                entity.Property(e => e.Sitcd)
                    .HasColumnName("SITCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Fprdcd)
                    .HasColumnName("FPRDCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Loccd)
                    .HasColumnName("LOCCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Tprdcd)
                    .HasColumnName("TPRDCD")
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Usremail>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Mnemonic });

                entity.ToTable("USREMAIL");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Mnemonic)
                    .HasColumnName("MNEMONIC")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Emailadd)
                    .HasColumnName("EMAILADD")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Valemail>(entity =>
            {
                entity.HasKey(e => new { e.Emaildmn, e.Emailtyp });

                entity.ToTable("VALEMAIL");

                entity.Property(e => e.Emaildmn)
                    .HasColumnName("EMAILDMN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Emailtyp)
                    .HasColumnName("EMAILTYP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vennowrk>(entity =>
            {
                entity.HasKey(e => new { e.Vencod, e.Nwrkdate });

                entity.ToTable("VENNOWRK");

                entity.Property(e => e.Vencod)
                    .HasColumnName("VENCOD")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Nwrkdate)
                    .HasColumnName("NWRKDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Datetext)
                    .HasColumnName("DATETEXT")
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vnctyprq>(entity =>
            {
                entity.HasKey(e => new { e.Vnctypcd, e.Colname });

                entity.ToTable("VNCTYPRQ");

                entity.Property(e => e.Vnctypcd)
                    .HasColumnName("VNCTYPCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Colname)
                    .HasColumnName("COLNAME")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Waitprm>(entity =>
            {
                entity.HasKey(e => new { e.Proctype, e.Strtday, e.Endday });

                entity.ToTable("WAITPRM");

                entity.Property(e => e.Proctype)
                    .HasColumnName("PROCTYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Strtday).HasColumnName("STRTDAY");

                entity.Property(e => e.Endday).HasColumnName("ENDDAY");

                entity.Property(e => e.Cmdaylim).HasColumnName("CMDAYLIM");

                entity.Property(e => e.Comcatcd)
                    .HasColumnName("COMCATCD")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Confmail)
                    .HasColumnName("CONFMAIL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Dnperslt).HasColumnName("DNPERSLT");

                entity.Property(e => e.Procord)
                    .HasColumnName("PROCORD")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Weightbg>(entity =>
            {
                entity.HasKey(e => new { e.Abogrp, e.Rhgrp, e.Gender });

                entity.ToTable("WEIGHTBG");

                entity.Property(e => e.Abogrp)
                    .HasColumnName("ABOGRP")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rhgrp)
                    .HasColumnName("RHGRP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<Weightph>(entity =>
            {
                entity.HasKey(e => new { e.Fct126, e.Gender });

                entity.ToTable("WEIGHTPH");

                entity.Property(e => e.Fct126)
                    .HasColumnName("FCT126")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<Weighttm>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("WEIGHTTM");

                entity.Property(e => e.Keyword)
                    .HasColumnName("KEYWORD")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<Wrdmmdef>(entity =>
            {
                entity.HasKey(e => new { e.Commscd, e.Fieldno });

                entity.ToTable("WRDMMDEF");

                entity.Property(e => e.Commscd)
                    .HasColumnName("COMMSCD")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Fieldno).HasColumnName("FIELDNO");

                entity.Property(e => e.Dataform)
                    .HasColumnName("DATAFORM")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Donfield)
                    .HasColumnName("DONFIELD")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
