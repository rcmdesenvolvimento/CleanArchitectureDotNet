using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Data.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10, 2);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Caderno",
                    Description = "Caderno Espiral 100 folhas",
                    Price = 9.50m
                },
                new Product
                {
                    Id = 2,
                    Name = "Borracha",
                    Description = "Borracha Branca pequena",
                    Price = 3.75m
                },
                new Product
                {
                    Id = 3,
                    Name = "",
                    Description = "Caderno Universitário 500 folhas",
                    Price = 59.50m
                }
                );
        }
    }
}
