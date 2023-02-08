using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myERP.Core.Entities;

namespace myERP.Data.contexts.configurations
{
    public class PeliculaConfiguration : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {

            builder.Property(prop => prop.Titulo)
                    .HasMaxLength(150);

            builder.Property(prop => prop.PosterURL)
                    .HasMaxLength(250);

            //builder.Property(prop => prop.FechaEstreno)
            //        .HasColumnType("date");
            builder.Property(prop => prop.PosterURL)
                .IsUnicode(false);

            //builder.HasMany(prop => prop.SalaDeCines)
            //    .WithMany(prop => prop.Peliculas)
            //    .UsingEntity(prop => prop.ToTable("PeliculasSalasDeCine"));
        }
    }
}
