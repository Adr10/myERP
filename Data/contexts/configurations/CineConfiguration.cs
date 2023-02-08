using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myERP.Core.Entities;

namespace myERP.Data.contexts.configurations
{
    public class CineConfiguration : IEntityTypeConfiguration<Cine>
    {
        public void Configure(EntityTypeBuilder<Cine> builder)
        {
            builder.HasKey(prop=>prop.cineId);
            builder.Property(prop => prop.Nombre)
                .HasMaxLength(150);
        }
    }
}
