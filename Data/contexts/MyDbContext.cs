

using Microsoft.EntityFrameworkCore;
using myERP.Core.Entities;
using myERP.Data.contexts.configurations;
using myERP.Data.contexts.seeding;

namespace myERP.Data.contexts
{
    public class MyDbContext : DbContext
    {
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<CineOferta> CinesOfertas { get; set; }
        public DbSet<SalaDeCine> SalasDeCines { get; set; }
        public DbSet<ActorPelicula> ActoresPeliculas { get; set; }
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var addedAuditedEntities = ChangeTracker.Entries<DbAudit>()
          .Where(x => x.State == EntityState.Added)
          .Select(x => x.Entity);

            var modifiedAuditedEntities = ChangeTracker.Entries<DbAudit>()
              .Where(x => x.State == EntityState.Modified)
              .Select(x => x.Entity);

            var now = DateTime.UtcNow;
            foreach (var added in addedAuditedEntities)
                added.CreateAt = added.UpdateAt = now;

            foreach (var modified in modifiedAuditedEntities)
                modified.UpdateAt = now;

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Genero>().HasKey(prop => prop.Identificador);

            var ConfigurationAssembly = typeof(GeneroConfiguration).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(ConfigurationAssembly,
                x => x.Namespace == typeof(GeneroConfiguration).Namespace
                    && x.Name.EndsWith("Configuration"));
            SeedingInitialData.Seed(modelBuilder);
        
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }
    }
}
