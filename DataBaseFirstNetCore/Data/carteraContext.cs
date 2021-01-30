using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataBaseFirstNetCore.Data
{
    public partial class carteraContext : DbContext
    {
  

        public carteraContext(DbContextOptions<carteraContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Backup> Backups { get; set; }
        public virtual DbSet<Capital> Capitals { get; set; }
        public virtual DbSet<Cartera> Carteras { get; set; }
        public virtual DbSet<Carteraspromotor> Carteraspromotors { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Community> Communities { get; set; }
        public virtual DbSet<Credit> Credits { get; set; }
        public virtual DbSet<Cuota> Cuotas { get; set; }
        public virtual DbSet<Departament> Departaments { get; set; }
        public virtual DbSet<Dollar> Dollars { get; set; }
        public virtual DbSet<Due> Dues { get; set; }
        public virtual DbSet<Estadistica> Estadisticas { get; set; }
        public virtual DbSet<FailedJob> FailedJobs { get; set; }
        public virtual DbSet<Fiador> Fiadors { get; set; }
        public virtual DbSet<Garantia> Garantias { get; set; }
        public virtual DbSet<Gestore> Gestores { get; set; }
        public virtual DbSet<Intere> Interes { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobBatch> JobBatches { get; set; }
        public virtual DbSet<Lastpay> Lastpays { get; set; }
        public virtual DbSet<Lastpayday> Lastpaydays { get; set; }
        public virtual DbSet<MigrateSup> MigrateSups { get; set; }
        public virtual DbSet<Migration> Migrations { get; set; }
        public virtual DbSet<Mora> Moras { get; set; }
        public virtual DbSet<Municipality> Municipalities { get; set; }
        public virtual DbSet<PasswordReset> PasswordResets { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Periocidad> Periocidads { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PermissionRole> PermissionRoles { get; set; }
        public virtual DbSet<PermissionUser> PermissionUsers { get; set; }
        public virtual DbSet<Promotore> Promotores { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleUser> RoleUsers { get; set; }
        public virtual DbSet<Saldoprincint> Saldoprincints { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<Security> Securities { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Sucursal> Sucursals { get; set; }
        public virtual DbSet<Supervisore> Supervisores { get; set; }
        public virtual DbSet<Ultimapago> Ultimapagos { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySql("server=localhost;port=3306;database=cartera;user=Manu;password=NicaraguaLibre.", Microsoft.EntityFrameworkCore.ServerVersion.FromString("8.0.21-mysql"));
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("activity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Sectorid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sectorid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Backup>(entity =>
            {
                entity.ToTable("backups");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Database)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("database")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Capital>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("capital");

                entity.Property(e => e.Capital1)
                    .HasPrecision(38, 2)
                    .HasColumnName("capital");

                entity.Property(e => e.Creditid).HasColumnName("creditid");
            });

            modelBuilder.Entity<Cartera>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("carteras");

                entity.Property(e => e.GestorId).HasColumnName("gestorId");

                entity.Property(e => e.GestorName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("gestorName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SaldoCapital)
                    .HasPrecision(37, 2)
                    .HasColumnName("saldoCapital");
            });

            modelBuilder.Entity<Carteraspromotor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("carteraspromotor");

                entity.Property(e => e.PromotorId).HasColumnName("promotorId");

                entity.Property(e => e.PromotorName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("promotorName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SaldoCapital)
                    .HasPrecision(37, 2)
                    .HasColumnName("saldoCapital");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("address")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Business)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("business")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Businessactivity)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("businessactivity")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Businessaddress)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("businessaddress")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Businesssector)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("businesssector")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Businesstime)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("businesstime")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Civilstatus)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("civilstatus")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Clientstatus).HasColumnName("clientstatus");

                entity.Property(e => e.Community)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("community")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Company)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("company")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Companyaddress)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("companyaddress")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Companypayment)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("companypayment")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Companyphone)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("companyphone")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Companyrole)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("companyrole")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Companytime)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("companytime")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Departament)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("departament")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("first_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Identification)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("identification")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LastName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("last_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Municipality)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("municipality")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Peoples)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("peoples")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("phone")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Profession)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("profession")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Register)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("register")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SecondLastname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("second_lastname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SecondName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("second_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Sex)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sex")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Community>(entity =>
            {
                entity.ToTable("community");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Municipality)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("municipality")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Credit>(entity =>
            {
                entity.ToTable("credits");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Atraso)
                    .HasPrecision(14, 2)
                    .HasColumnName("atraso");

                entity.Property(e => e.Cantidadpagar)
                    .HasPrecision(14, 2)
                    .HasColumnName("cantidadpagar");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Cuotafixed)
                    .HasPrecision(14, 2)
                    .HasColumnName("cuotafixed");

                entity.Property(e => e.Cuotapagar)
                    .HasPrecision(14, 2)
                    .HasColumnName("cuotapagar");

                entity.Property(e => e.Cuotaprincipal)
                    .HasPrecision(14, 2)
                    .HasColumnName("cuotaprincipal");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.Destino)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("destino")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.DiasMora).HasColumnName("dias_mora");

                entity.Property(e => e.Entregado).HasColumnName("entregado");

                entity.Property(e => e.Fecha1cuota)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fecha1cuota")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Fechaentrega)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fechaentrega")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Fechasolicitud)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fechasolicitud")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Fechavencimiento)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fechavencimiento")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Gastosadmin)
                    .HasPrecision(8, 2)
                    .HasColumnName("gastosadmin");

                entity.Property(e => e.Gestorcobro).HasColumnName("gestorcobro");

                entity.Property(e => e.Interescorriente)
                    .HasPrecision(4, 2)
                    .HasColumnName("interescorriente");

                entity.Property(e => e.Interesmoratorio)
                    .HasPrecision(5, 2)
                    .HasColumnName("interesmoratorio");

                entity.Property(e => e.Moneda)
                    .HasColumnName("moneda")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MontoCancelacion)
                    .HasPrecision(14, 2)
                    .HasColumnName("monto_cancelacion");

                entity.Property(e => e.Montoentregado)
                    .HasPrecision(14, 2)
                    .HasColumnName("montoentregado");

                entity.Property(e => e.Montofixed)
                    .HasPrecision(14, 2)
                    .HasColumnName("montofixed");

                entity.Property(e => e.Montointeres)
                    .HasPrecision(10, 2)
                    .HasColumnName("montointeres");

                entity.Property(e => e.Montoprincipal)
                    .HasPrecision(14, 2)
                    .HasColumnName("montoprincipal");

                entity.Property(e => e.Periodicidad).HasColumnName("periodicidad");

                entity.Property(e => e.Plazo).HasColumnName("plazo");

                entity.Property(e => e.Promotor).HasColumnName("promotor");

                entity.Property(e => e.Recurrent).HasColumnName("recurrent");

                entity.Property(e => e.Special)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("special")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Statussolicitud).HasColumnName("statussolicitud");

                entity.Property(e => e.Supervisor).HasColumnName("supervisor");

                entity.Property(e => e.Tazacambio)
                    .HasPrecision(6, 4)
                    .HasColumnName("tazacambio");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Cuota>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cuotas");

                entity.Property(e => e.Creditid).HasColumnName("creditid");

                entity.Property(e => e.Fechapago)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fechapago")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SaldoInteres)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoInteres");

                entity.Property(e => e.SaldoPrincipal)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoPrincipal");
            });

            modelBuilder.Entity<Departament>(entity =>
            {
                entity.ToTable("departaments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Dollar>(entity =>
            {
                entity.ToTable("dollar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("amount")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Due>(entity =>
            {
                entity.ToTable("dues");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbonoInteres)
                    .HasPrecision(16, 2)
                    .HasColumnName("abonoInteres");

                entity.Property(e => e.AbonoMora)
                    .HasPrecision(16, 2)
                    .HasColumnName("abonoMora");

                entity.Property(e => e.AbonoPrincipal)
                    .HasPrecision(16, 2)
                    .HasColumnName("abonoPrincipal");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.Concepto)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("concepto")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreditId).HasColumnName("creditId");

                entity.Property(e => e.DiasMora).HasColumnName("diasMora");

                entity.Property(e => e.DueStatus).HasColumnName("dueStatus");

                entity.Property(e => e.Equivalencia)
                    .HasPrecision(16, 2)
                    .HasColumnName("equivalencia");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("timestamp")
                    .HasColumnName("fechaIngreso");

                entity.Property(e => e.FechaNulo)
                    .HasColumnType("timestamp")
                    .HasColumnName("fechaNulo");

                entity.Property(e => e.FechaPago)
                    .HasColumnType("date")
                    .HasColumnName("fechaPago");

                entity.Property(e => e.GestorId).HasColumnName("gestorId");

                entity.Property(e => e.InteresMoratorio)
                    .HasPrecision(16, 2)
                    .HasColumnName("interesMoratorio");

                entity.Property(e => e.Moneda)
                    .HasColumnName("moneda")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MontoMora)
                    .HasPrecision(14, 2)
                    .HasColumnName("montoMora");

                entity.Property(e => e.Nulo).HasColumnName("nulo");

                entity.Property(e => e.Office).HasColumnName("office");

                entity.Property(e => e.PaymentCuotaId).HasColumnName("paymentCuotaId");

                entity.Property(e => e.PaymentId).HasColumnName("paymentId");

                entity.Property(e => e.PromotorId).HasColumnName("promotorId");

                entity.Property(e => e.SaldoInteres)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoInteres");

                entity.Property(e => e.SaldoMora)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoMora");

                entity.Property(e => e.SaldoPrincipal)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoPrincipal");

                entity.Property(e => e.TipoCambio)
                    .HasPrecision(8, 4)
                    .HasColumnName("tipoCambio");

                entity.Property(e => e.TotalPagado)
                    .HasPrecision(16, 2)
                    .HasColumnName("totalPagado");

                entity.Property(e => e.Transaccion).HasColumnName("transaccion");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Estadistica>(entity =>
            {
                entity.ToTable("estadisticas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Atrasos)
                    .HasPrecision(16, 2)
                    .HasColumnName("atrasos");

                entity.Property(e => e.Cartera)
                    .HasPrecision(16, 2)
                    .HasColumnName("cartera");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.GestorId).HasColumnName("gestorId");

                entity.Property(e => e.NombreGestor)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("nombreGestor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.NombreSupervisor)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("nombreSupervisor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PorcentajeAtrasos)
                    .HasPrecision(6, 2)
                    .HasColumnName("porcentajeAtrasos");

                entity.Property(e => e.PorcentajeMora)
                    .HasPrecision(6, 2)
                    .HasColumnName("porcentajeMora");

                entity.Property(e => e.PorcentajeVencidos)
                    .HasPrecision(6, 2)
                    .HasColumnName("porcentajeVencidos");

                entity.Property(e => e.SupervisorId).HasColumnName("supervisorId");

                entity.Property(e => e.TotalClientes).HasColumnName("totalClientes");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Vencidos)
                    .HasPrecision(16, 2)
                    .HasColumnName("vencidos");
            });

            modelBuilder.Entity<FailedJob>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.HasIndex(e => e.Uuid, "failed_jobs_uuid_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Connection)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("connection")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Exception)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("exception")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("failed_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("payload")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("queue")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("uuid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Fiador>(entity =>
            {
                entity.ToTable("fiador");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("activity")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("address")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Civilstatus)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("civilstatus")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Company)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("company")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Companyaddress)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("companyaddress")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Companyrole)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("companyrole")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Companytime)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("companytime")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Creditid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("creditid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Departament)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("departament")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Identification)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("identification")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Municipality)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("municipality")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Ocupation)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ocupation")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Parents)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("parents")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("phone")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Sector)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sector")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Garantia>(entity =>
            {
                entity.ToTable("garantias");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Article)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("article")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Color)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("color")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreditId).HasColumnName("credit_id");

                entity.Property(e => e.Mark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mark")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("model")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Serie)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("serie")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasPrecision(10, 2)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Gestore>(entity =>
            {
                entity.ToTable("gestores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Office).HasColumnName("office");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Supervisor).HasColumnName("supervisor");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Intere>(entity =>
            {
                entity.ToTable("interes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Interes)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("interes")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("jobs");

                entity.HasIndex(e => e.Queue, "jobs_queue_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attempts).HasColumnName("attempts");

                entity.Property(e => e.AvailableAt).HasColumnName("available_at");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("payload")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("queue")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ReservedAt).HasColumnName("reserved_at");
            });

            modelBuilder.Entity<JobBatch>(entity =>
            {
                entity.ToTable("job_batches");

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CancelledAt).HasColumnName("cancelled_at");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.FailedJobIds)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("failed_job_ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FailedJobs).HasColumnName("failed_jobs");

                entity.Property(e => e.FinishedAt).HasColumnName("finished_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Options)
                    .HasColumnType("text")
                    .HasColumnName("options")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PendingJobs).HasColumnName("pending_jobs");

                entity.Property(e => e.TotalJobs).HasColumnName("total_jobs");
            });

            modelBuilder.Entity<Lastpay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("lastpay");

                entity.Property(e => e.CreditId)
                    .HasColumnName("creditId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UltimoPago)
                    .HasColumnType("date")
                    .HasColumnName("ultimoPago");
            });

            modelBuilder.Entity<Lastpayday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("lastpaydays");

                entity.Property(e => e.CreditId).HasColumnName("creditId");

                entity.Property(e => e.DiasMora)
                    .HasPrecision(32)
                    .HasColumnName("diasMora");

                entity.Property(e => e.PaymentId).HasColumnName("paymentId");
            });

            modelBuilder.Entity<MigrateSup>(entity =>
            {
                entity.ToTable("migrate_sup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.SupId).HasColumnName("sup_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("migration")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Mora>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mora");

                entity.Property(e => e.Creditid).HasColumnName("creditid");

                entity.Property(e => e.DiasMora).HasColumnName("diasMora");

                entity.Property(e => e.Fechapago)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fechapago")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Paymentstatus).HasColumnName("paymentstatus");

                entity.Property(e => e.SaldoInteres)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoInteres");

                entity.Property(e => e.SaldoMora)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoMora");

                entity.Property(e => e.SaldoPrincipal)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoPrincipal");
            });

            modelBuilder.Entity<Municipality>(entity =>
            {
                entity.ToTable("municipality");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DepartamentId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("departament_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.HasIndex(e => e.Email, "password_resets_email_index");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("payment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbonoInteres)
                    .HasPrecision(14, 2)
                    .HasColumnName("abonoInteres");

                entity.Property(e => e.AbonoMora)
                    .HasPrecision(14, 2)
                    .HasColumnName("abonoMora");

                entity.Property(e => e.AbonoPrincipal)
                    .HasPrecision(14, 2)
                    .HasColumnName("abonoPrincipal");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Creditid).HasColumnName("creditid");

                entity.Property(e => e.Cuotapagar)
                    .HasPrecision(14, 2)
                    .HasColumnName("cuotapagar");

                entity.Property(e => e.Cuotaprincipal)
                    .HasPrecision(14, 2)
                    .HasColumnName("cuotaprincipal");

                entity.Property(e => e.DiasMora).HasColumnName("diasMora");

                entity.Property(e => e.Fechapago)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fechapago")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Interescorriente)
                    .HasPrecision(5, 2)
                    .HasColumnName("interescorriente");

                entity.Property(e => e.Interesmoratorio)
                    .HasPrecision(14, 2)
                    .HasColumnName("interesmoratorio");

                entity.Property(e => e.Montointeres)
                    .HasPrecision(14, 2)
                    .HasColumnName("montointeres");

                entity.Property(e => e.Montomora)
                    .HasPrecision(14, 2)
                    .HasColumnName("montomora");

                entity.Property(e => e.Nuevosaldo)
                    .HasPrecision(14, 2)
                    .HasColumnName("nuevosaldo");

                entity.Property(e => e.Numcuota).HasColumnName("numcuota");

                entity.Property(e => e.Paymentstatus).HasColumnName("paymentstatus");

                entity.Property(e => e.Periodicidad).HasColumnName("periodicidad");

                entity.Property(e => e.SaldoInteres)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoInteres");

                entity.Property(e => e.SaldoMora)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoMora");

                entity.Property(e => e.SaldoPrincipal)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoPrincipal");

                entity.Property(e => e.Saldoanterior)
                    .HasPrecision(14, 2)
                    .HasColumnName("saldoanterior");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Periocidad>(entity =>
            {
                entity.ToTable("periocidad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidaddias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cantidaddias")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Cuotadias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cuotadias")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Periocidad1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("periocidad")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permissions");

                entity.HasIndex(e => e.Slug, "permissions_slug_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("slug")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PermissionRole>(entity =>
            {
                entity.ToTable("permission_role");

                entity.HasIndex(e => e.PermissionId, "permission_role_permission_id_index");

                entity.HasIndex(e => e.RoleId, "permission_role_role_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionRoles)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("permission_role_permission_id_foreign");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PermissionRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("permission_role_role_id_foreign");
            });

            modelBuilder.Entity<PermissionUser>(entity =>
            {
                entity.ToTable("permission_user");

                entity.HasIndex(e => e.PermissionId, "permission_user_permission_id_index");

                entity.HasIndex(e => e.UserId, "permission_user_user_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionUsers)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("permission_user_permission_id_foreign");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PermissionUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("permission_user_user_id_foreign");
            });

            modelBuilder.Entity<Promotore>(entity =>
            {
                entity.ToTable("promotores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Office).HasColumnName("office");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Supervisor).HasColumnName("supervisor");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.ToTable("quotes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreditId).HasColumnName("creditId");

                entity.Property(e => e.CuotaAbonada)
                    .HasPrecision(12, 2)
                    .HasColumnName("cuotaAbonada");

                entity.Property(e => e.CuotaConcepto)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cuotaConcepto")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaIngreso");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("userId")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.ToTable("references");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("address")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Clientid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("clientid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Parent)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("parent")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("phone")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.HasIndex(e => e.Name, "roles_name_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Slug, "roles_slug_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("slug")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Special)
                    .HasColumnType("enum('all-access','no-access')")
                    .HasColumnName("special")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<RoleUser>(entity =>
            {
                entity.ToTable("role_user");

                entity.HasIndex(e => e.RoleId, "role_user_role_id_index");

                entity.HasIndex(e => e.UserId, "role_user_user_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("role_user_role_id_foreign");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RoleUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("role_user_user_id_foreign");
            });

            modelBuilder.Entity<Saldoprincint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("saldoprincint");

                entity.Property(e => e.Capital).HasColumnName("capital");

                entity.Property(e => e.Creditid).HasColumnName("creditid");
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.ToTable("sector");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Security>(entity =>
            {
                entity.ToTable("security");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Device)
                    .HasColumnType("date")
                    .HasColumnName("device");

                entity.Property(e => e.End)
                    .HasColumnType("date")
                    .HasColumnName("end");

                entity.Property(e => e.Start)
                    .HasColumnType("date")
                    .HasColumnName("start");

                entity.Property(e => e.Token)
                    .HasColumnType("date")
                    .HasColumnName("token");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("date")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("server");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.End)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("end")
                    .HasDefaultValueSql("'20:00'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Start)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("start")
                    .HasDefaultValueSql("'7:00'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sessions");

                entity.HasIndex(e => e.Id, "sessions_id_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.IpAddress)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("ip_address")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LastActivity).HasColumnName("last_activity");

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("payload")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserAgent)
                    .HasColumnType("text")
                    .HasColumnName("user_agent")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.ToTable("sucursal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("address")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Departament)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("departament")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("phone")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Supervisore>(entity =>
            {
                entity.ToTable("supervisores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Office).HasColumnName("office");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Supervisor).HasColumnName("supervisor");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Ultimapago>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ultimapago");

                entity.Property(e => e.CreditId).HasColumnName("creditId");

                entity.Property(e => e.MaxFechaPago).HasColumnName("maxFechaPago");

                entity.Property(e => e.PaymentId).HasColumnName("paymentId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email, "users_email_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "users_username_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("address")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ApiToken)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("api_token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("first_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.GestorId).HasColumnName("gestor_id");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("last_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Office)
                    .HasColumnName("office")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("password")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("phone")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Placa)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("placa")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.RememberToken)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("remember_token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SecondLastname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("second_lastname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SecondName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("second_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Sex)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sex")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("supervisor")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Suspend).HasColumnName("suspend");

                entity.Property(e => e.Theme).HasColumnName("theme");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("username")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Vehiculotype)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vehiculotype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
