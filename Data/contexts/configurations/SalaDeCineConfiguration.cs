using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myERP.Core.Entities;
using myERP.Core.Enums;

namespace myERP.Data.contexts.configurations
{
    public class SalaDeCineConfiguration : IEntityTypeConfiguration<SalaDeCine>
    {
        public void Configure(EntityTypeBuilder<SalaDeCine> builder)
        {
            builder.HasKey(prop=>prop.Id);
            builder.Property(prop => prop.Precio)
                .HasPrecision(18, 2);

            builder.Property(prop => prop.TipoSalaDeCine)
                .HasDefaultValue(TipoSalaDeCine.DosDimensiones);
        }
    }
}
