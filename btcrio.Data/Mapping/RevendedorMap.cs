using btc.Domain.Entiity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace btc.Data.Mapping
{
    public class RevendedorMap : IEntityTypeConfiguration<RevendedorEntity>
    {
        public void Configure(EntityTypeBuilder<RevendedorEntity> builder)
        {
            builder.ToTable("Revendedores");

            builder.HasKey(r => r.Id);

            builder.HasIndex(p => p.Email)
                    .IsUnique();

            builder.Property(p => p.NomeCompleto)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Email)
                .HasMaxLength(100);
        }
    }
}
