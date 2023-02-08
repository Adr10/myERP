using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myERP.Core.Entities;
using System.Reflection.Emit;

namespace myERP.Data.contexts.configurations
{
    public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
           builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nombre)
                .HasMaxLength(150)
                .IsRequired();



            builder.HasQueryFilter(prop => !prop.estaBorrado);
        }
    }
}
