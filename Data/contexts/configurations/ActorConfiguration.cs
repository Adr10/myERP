using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myERP.Core.Entities;

namespace myERP.Data.contexts.configurations
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
           
            builder.Property(prop => prop.Nombre)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(prop => prop.Biografia)
                 .HasColumnName("ColumBiografia");
        

            //builder.Property(prop => prop.FechaNacimiento)
            //    .HasColumnType("date");

            builder.ToTable(name: "TablaActores", schema: "peliculas");

        }
    }
}
