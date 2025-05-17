using InstrumentalHub.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace InstrumentalHub.Configurations;

public class IntrumentoCategoriaConfiguration : IEntityTypeConfiguration<InstrumentoCategoria>
{
    public void Configure(EntityTypeBuilder<InstrumentoCategoria> builder)
    {
        builder.Property(ic => ic.Nombre).HasMaxLength(200).IsRequired();
    }
}