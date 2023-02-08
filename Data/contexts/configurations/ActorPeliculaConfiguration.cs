using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myERP.Core.Entities;

namespace myERP.Data.contexts.configurations
{
    public class ActorPeliculaConfiguration : IEntityTypeConfiguration<ActorPelicula>
    {
        public void Configure(EntityTypeBuilder<ActorPelicula> builder)
        {
            builder.HasKey(prop => new {prop.ActorId,prop.PeliculaId});

            builder.Property(prop => prop.Personaje)
                .HasMaxLength(150);
        }
    }
}
